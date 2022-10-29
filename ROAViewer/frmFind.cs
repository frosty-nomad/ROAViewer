using Realms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROAViewer
{
    public enum FindSearchType
    {
        Buy,
        Sell,
        Service,
        Train
    }

    public partial class frmFind : Form
    {
        public RealmsData RealmsData { get; set; }
        public RealmsMaps RealmsMaps { get; set;  }
        public int MapSet { get; set; }
        public int MapIndex { get; set; }
        public int MapX { get; set; }
        public int MapY { get; set; }
        public BindingList<Tuple<string, string>> MapNames { get; set; }

        public frmFind()
        {
            InitializeComponent();
        }

        private void Search(FindSearchType type)
        {
            cboBuy.Enabled = false;
            btnBuy.Enabled = false;
            cboSell.Enabled = false;
            btnSell.Enabled = false;
            cboService.Enabled = false;
            btnService.Enabled = false;
            cboTrain.Enabled = false;
            btnTrain.Enabled = false;

            dgvResults.Visible = false;
            lblSearching.Visible = true;

            switch (type)
            {
                case FindSearchType.Buy:
                    dgvResults.Columns[3].HeaderText = "Buy";
                    Search(SearchBuy);
                    break;
                case FindSearchType.Sell:
                    dgvResults.Columns[3].HeaderText = "Sell";
                    Search(SearchSell);
                    break;
                case FindSearchType.Service:
                    dgvResults.Columns[3].HeaderText = "Service";
                    Search(SearchService);
                    break;
                case FindSearchType.Train:
                    dgvResults.Columns[3].HeaderText = "Training";
                    Search(SearchTrain);
                    break;
            }

            cboBuy.Enabled = true;
            btnBuy.Enabled = cboBuy.SelectedIndex > -1;
            cboSell.Enabled = true;
            btnSell.Enabled = cboSell.SelectedIndex > -1;
            cboService.Enabled = true;
            btnService.Enabled = cboService.SelectedIndex > -1;
            cboTrain.Enabled = true;
            btnTrain.Enabled = cboTrain.SelectedIndex > -1;

            lblSearching.Visible = false;
            dgvResults.Visible = true;
        }

        private void Search(Func<RealmsTransaction, RealmsMob, RealmsMap, List<RealmsSearch>> searchFilter)
        {
            var results = new List<RealmsSearch>();
            foreach (var set in RealmsMaps.Mapsets)
            {
                foreach (var map in set.Maps)
                {
                    Status($"Searching Vendors in Set{map.Set}-{map.Index}...");
                    foreach (var mob in map.Mobs.Mobs.Where(m => m.Type == RealmsMobType.Transaction || m.Type == RealmsMobType.NTransaction))
                    {
                        var trans = set.Transactions.FirstOrDefault(t => t.Sector == mob.Sector && t.Offset == mob.Data[1]);
                        if (trans != null)
                        {
                            results.AddRange(searchFilter(trans, mob, map));
                        }
                    }
                }
            }
            dgvResults.DataSource = results;
        }

        private List<RealmsSearch> SearchBuy(RealmsTransaction trans, RealmsMob mob, RealmsMap map)
        {
            var results = new List<RealmsSearch>();
            var item = (string)cboBuy.SelectedItem;
            var title = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Title);
            var mName = MapNames.FirstOrDefault(n => n.Item2 == $"{map.Set},{map.Index}");
            var buy = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Buy);
            if (buy != null)
            {
                foreach(var text in buy.Texts)
                {
                    if (text.Contains(item))
                    {
                        results.Add(new RealmsSearch
                        {
                            Map = mName != null ? mName.Item1 : $"Set{map.Set}-{map.Index}",
                            Location = $"{mob.X},{mob.Y}",
                            Vendor = $"{(title != null ? title.Texts[0] : "NPC")}",
                            Item = text,
                            Coords = $"{map.Set},{map.Index},{mob.X},{mob.Y}"
                        });
                    }
                }
            }
            return results;
        }

        private List<RealmsSearch> SearchSell(RealmsTransaction trans, RealmsMob mob, RealmsMap map)
        {
            var results = new List<RealmsSearch>();
            var item = (Tuple<int, string>)cboSell.SelectedItem;
            var title = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Title);
            var mName = MapNames.FirstOrDefault(n => n.Item2 == $"{map.Set},{map.Index}");
            var sell = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Sell);
            if (sell != null)
            {
                if (sell.Texts.Any(t => t.Contains(item.Item2)))
                {
                    results.Add(new RealmsSearch
                    {
                        Map = mName != null ? mName.Item1 : $"Set{map.Set}-{map.Index}",
                        Location = $"{mob.X},{mob.Y}",
                        Vendor = $"{(title != null ? title.Texts[0] : "NPC")}",
                        Item = item.Item2,
                        Coords = $"{map.Set},{map.Index},{mob.X},{mob.Y}"
                    });
                }
            }
            return results;
        }

        private List<RealmsSearch> SearchService(RealmsTransaction trans, RealmsMob mob, RealmsMap map)
        {
            var results = new List<RealmsSearch>();
            var item = (string)cboService.SelectedItem;
            var title = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Title);
            var mName = MapNames.FirstOrDefault(n => n.Item2 == $"{map.Set},{map.Index}");

            var add = false;
            var text = "";
            switch (item.ToLower())
            {
                case "rest":
                case "drink":
                    foreach (var option in trans.Instructions.Where(o => o.Type == RealmsInstType.Option))
                    {
                        if (((item == "Drink" && title != null) || item != "Drink") &&  
                            option.Texts.Any(t => t.Contains(item)))
                        {
                            text = item;
                            add = true;
                            break;
                        }
                    }
                    break;
                case "gamble":
                    var gamble = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Gamble);
                    if (gamble != null)
                    {
                        text = $"Gamble {gamble.Texts[0]}";
                        add = true;
                        break;
                    }
                    break;

                case "cure":
                    var cure = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Cure);
                    if (cure != null)
                    {
                        text = $"Cure {cure.Texts[0]}";
                        add = true;
                    }
                    break;

                case "heal":
                    var heal = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Heal);
                    if (heal != null)
                    {
                        text = $"Heal {heal.Texts[0]}";
                        add = true;
                    }
                    break;

                case "identify":
                    var ident = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Reveal);
                    if (ident != null)
                    {
                        text = $"Identify {ident.Texts[0]}";
                        add = true;
                    }
                    break;
            }

            if (add)
            {
                results.Add(new RealmsSearch
                {
                    Map = mName != null ? mName.Item1 : $"Set{map.Set}-{map.Index}",
                    Location = $"{mob.X},{mob.Y}",
                    Vendor = $"{(title != null ? title.Texts[0] : "NPC")}",
                    Item = text,
                    Coords = $"{map.Set},{map.Index},{mob.X},{mob.Y}"
                });
            }

            return results;
        }

        private List<RealmsSearch> SearchTrain(RealmsTransaction trans, RealmsMob mob, RealmsMap map)
        {
            var results = new List<RealmsSearch>();
            var item = (string)cboTrain.SelectedItem;
            var title = trans.Instructions.FirstOrDefault(i => i.Type == RealmsInstType.Title);
            var mName = MapNames.FirstOrDefault(n => n.Item2 == $"{map.Set},{map.Index}");
            var trains = trans.Instructions.Where(i => i.Type == RealmsInstType.Train).ToList();
            foreach(var train in trains)
            {
                foreach(var text in train.Texts)
                {
                    if (text.StartsWith($"{item}"))
                    {
                        results.Add(new RealmsSearch
                        {
                            Map = mName != null ? mName.Item1 : $"Set{map.Set}-{map.Index}",
                            Location = $"{mob.X},{mob.Y}",
                            Vendor = $"{(title != null ? title.Texts[0] : "NPC")}",
                            Item = text,
                            Coords = $"{map.Set},{map.Index},{mob.X},{mob.Y}"
                        });
                    }
                }
            }
            return results;
        }

        private void Status(string status)
        {
            lblSearching.Text = status;
            Application.DoEvents();
        }

        private void frmFind_Load(object sender, EventArgs e)
        {
            lblSearching.Visible = false;
            dgvResults.AutoGenerateColumns = false;
            dgvResults.Visible = false;

            cboBuy.DataSource = RealmsData.Items.Select(i => i.Name).ToList();
            cboBuy.SelectedIndex = -1;

            cboSell.DataSource = RealmsData.Types.Select(t => new Tuple<int, string>(t.Key, t.Value)).ToList();
            cboSell.SelectedIndex = -1;

            var services = new List<string>
            {
                "Cure",
                "Drink",
                "Gamble",
                "Heal",
                "Identify",
                "Rest"
            };
            cboService.DataSource = services;
            cboService.SelectedIndex = -1;

            var trains = new List<string>();
            foreach (var skill in Enum.GetValues(typeof(RealmsSkillType)))
            {
                var desc = (RealmsSkillType)skill;
                trains.Add(desc.GetDescription());
            }
            cboTrain.DataSource = trains;
            cboTrain.SelectedIndex = -1;
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            Search(FindSearchType.Buy);
        }

        private void btnSell_Click(object sender, EventArgs e)
        {
            Search(FindSearchType.Sell);
        }

        private void btnService_Click(object sender, EventArgs e)
        {
            Search(FindSearchType.Service);
        }

        private void btnTrain_Click(object sender, EventArgs e)
        {
            Search(FindSearchType.Train);
        }

        private void cboBuy_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnBuy.Enabled = cboBuy.SelectedIndex > -1;
        }

        private void cboBuy_TextUpdate(object sender, EventArgs e)
        {
            btnBuy.Enabled = cboBuy.SelectedIndex > -1;
        }

        private void cboSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSell.Enabled = cboSell.SelectedIndex > -1;
        }

        private void cboSell_TextUpdate(object sender, EventArgs e)
        {
            btnSell.Enabled = cboSell.SelectedIndex > -1;
        }

        private void cboService_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnService.Enabled = cboService.SelectedIndex > -1;
        }

        private void cboService_TextUpdate(object sender, EventArgs e)
        {
            btnService.Enabled = cboService.SelectedIndex > -1;
        }

        private void cboTrain_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnTrain.Enabled = cboTrain.SelectedIndex > -1;
        }

        private void cboTrain_TextUpdate(object sender, EventArgs e)
        {
            btnTrain.Enabled = cboTrain.SelectedIndex > -1;
        }

        private void dgvResults_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                var row = senderGrid.SelectedRows[0];
                var coords = row.Cells[4].Value.ToString().Split(',');
                MapSet = int.Parse(coords[0]);
                MapIndex = int.Parse(coords[1]);
                MapX = int.Parse(coords[2]);
                MapY = int.Parse(coords[3]);
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void dgvResults_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                e.Value = "Go To Map";
            }
        }
    }
}
