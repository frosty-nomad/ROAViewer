using Realms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text.Json;
using System.Windows.Forms;

namespace ROAViewer
{
    public partial class frmMain : Form
    {
        private string _realmsDir;
        private RealmsData _realmsData;
        private RealmsMaps _realmsMaps;

        private RealmsArmor _curArmor;
        private RealmsEdge _curEdge;
        private RealmsInfo _curInfo;
        private RealmsMap _curMap;
        private RealmsWeapon _curWeapon;

        private string _infoFileName;

        private int _centerX = -1;
        private int _centerY = -1;
        private int _curX = -1;
        private int _curY = -1;
        private bool _editMode;
        private Point _notesPoint;
        private int _prevPlayer = -1;
        private BindingList<Tuple<string, string>> _mapNames;

        private frmLoading _frmLoading = new frmLoading();
        private frmFind _frmFind = new frmFind();
        private frmMap _frmMap = new frmMap();
        private frmMobs _frmMobs = new frmMobs();
        private frmOptions _frmOptions = new frmOptions();

        public frmMain()
        {
            InitializeComponent();
        }

        public void BuildChars()
        {
            _realmsData.Chars = RealmsChar.LoadChars(_realmsDir, _realmsData.Options);
        }

        private void BackpackAmmo(int index)
        {
            var bCbo = (ComboBox)(Controls.Find($"cboIBackpack{index}", true)[0]);
            var bNud = (NumericUpDown)(Controls.Find($"nudBack{index}", true)[0]);

            var selItem = (Tuple<string, string>)bCbo.SelectedItem;
            if (selItem != null)
            {
                var values = selItem.Item2.Split(',');
                var type = int.Parse(values[0]);
                var idx = int.Parse(values[1]);
                var isAmmo = RealmsItem.IsAmmo(Convert.ToByte(type));

                var tItem = RealmsItem.GetItem(type, isAmmo ? 0 : idx, _realmsData.Items);
                bNud.Visible = tItem != null && RealmsItem.IsAmmo(tItem.Data);
            }
            else
            {
                bNud.Visible = false;
            }
        }

        private void BindRealmsData()
        {
            _curArmor = _realmsData.Armor[0];
            _curWeapon = _realmsData.Weapons[0];

            dgvArmor.AutoGenerateColumns = false;
            dgvArmor.DataSource = SetArmorDataSource();
            SetArmorCompare();
            cboCurArmor.DataSource = _realmsData.Armor.Select(a => a.Name).ToList();

            dgvWeapons.AutoGenerateColumns = false;
            dgvWeapons.DataSource = SetWeaponsDataSource();
            SetWeaponCompare();
            cboCurWeapon.DataSource = _realmsData.Weapons.Select(w => w.Name).ToList();

            dgvSpells.AutoGenerateColumns = false;
            dgvSpells.DataSource = SetSpellDataSource();

            dgvBooks.AutoGenerateColumns = false;
            dgvBooks.DataSource = SetSpellbookDataSource();

            dgvMonsters.AutoGenerateColumns = false;
            dgvMonsters.DataSource = SetMonsterDataSource();

            dgvItems.AutoGenerateColumns = false;
            dgvItems.DataSource = SetItemDataSource();

            dgvPlayerStates.AutoGenerateColumns = false;

            cboClass.DataSource = _realmsData.Classes;
        }

        private void BuildCharset(RealmsData rData)
        {
            var bitmap = RealmsChar.CharsetBitmap(_realmsData.Chars, lstChars.SelectedIndex, rData, true);
            picCharset.Width = bitmap.Width;
            picCharset.Height = bitmap.Height;
            picCharset.Image = bitmap;
        }

        private void BuildCharsets()
        {
            for(var c = 0; c < RealmsChar.CountCharsets; c++)
            {
                lstChars.Items.Add($"Charset{c}");
            }
            lstChars.SelectedIndex = 0;
        }

        public void BuildMap()
        {
            if (lstMaps.SelectedItem != null)
            {
                var item = (Tuple<string, string>)lstMaps.SelectedItem;
                var values = item.Item2.Split(',');
                var set = int.Parse(values[0]);
                var index = int.Parse(values[1]);
                _curMap = _realmsMaps.GetMap(set, index, _realmsData);

                var bitmap = RealmsMap.BuildBitmap(_curMap, _realmsData);
                picMap.Width = bitmap.Width;
                picMap.Height = bitmap.Height;
                picMap.Image = bitmap;
                lblMapset.Text = set.ToString();
                lblMapIndex.Text = index.ToString();
                txtMapName.Text = item.Item1;

                if (_centerX > -1 && _centerY > -1)
                {
                    CenterMap(splitContainer4.Panel2, _centerX, _centerY, _curMap, _realmsData);
                    splitContainer4.Panel2.Refresh();
                    _centerX = -1;
                    _centerY = -1;
                }
            }
        }

        private void BuildMaps()
        {
            InfoFileDate();
            var maps = new List<Tuple<string, string>>();
            foreach (var ms in _realmsMaps.Mapsets)
            {
                foreach (var m in ms.Maps)
                {
                    maps.Add(new Tuple<string, string>(m.Info.Name, $"{m.Set},{m.Index}"));
                }
            }
            _mapNames = new BindingList<Tuple<string, string>>(maps);
            lstMaps.DataSource = _mapNames;
        }

        private void BuildParty()
        {
            var party = _realmsData.Party;
            nudMoney.Value = party.Money;
            nudRations.Value = party.Rations;
            nudMapset.Value = party.Mapset;
            nudMapIndex.Value = party.MapIndex;
            nudXPos.Value = party.X;
            nudYPos.Value = party.Y;
            nudLight.Value = party.Light;
            nudLightInt.Value = party.LightInt;
            nudStepwatch.Value = party.Stepwatch;
            nudStealth.Value = party.Stealth;
            nudSense.Value = party.Sense;

            cboPlayer.Items.Clear();
            foreach(var player in party.Players)
            {
                cboPlayer.Items.Add(player.Name);
            }
            cboPlayer.SelectedIndex = 0;
            LoadPlayer(cboPlayer.SelectedIndex);
        }

        public static void CenterMap(Panel panel, int centerX, int centerY, RealmsMap map, RealmsData rData)
        {
            var tSize = RealmsMap.CalcTileSize(rData.Options);
            var cX = centerX > (map.Width - 1) ? 0 : centerX;
            var cY = centerY > (map.Height - 1) ? 0 :centerY;

            var pWidth = panel.Width - (panel.VerticalScroll.Visible ? 22 : 0);
            var pcX = panel.Width / 2;
            var pHeight = panel.Height - (panel.HorizontalScroll.Visible ? 22 : 0);
            var pcY = panel.Height / 2;

            RealmsMap.CalcBitmap(map, rData.Options, out var mWidth, out var mHeight);
            var x = RealmsMap.CalcBitmapX(map, cX, cY, tSize);
            var y = cY * tSize;

            var xScroll = x - pcX < 0 ? 0 : x - pcX;
            xScroll = xScroll + pWidth > mWidth ? mWidth - pWidth : xScroll;
            panel.HorizontalScroll.Value = xScroll < 0 ? 0 : xScroll;

            var yScroll = y - pcY < 0 ? 0 : y - pcY;
            yScroll = yScroll + pHeight > mHeight ? mHeight - pHeight : yScroll;
            panel.VerticalScroll.Value = yScroll < 0 ? 0 : yScroll;

            panel.PerformLayout();
        }

        private string FormatSaveDate(DateTime dt)
        {
            return dt.ToString("MM/dd/yy h:mm:sstt");
        }

        private string GetMapName(RealmsInfo info)
        {
            if (info.Mapset > -1 && info.Mapset < _realmsMaps.Mapsets.Count)
            {
                var map = _realmsMaps.Mapsets[info.Mapset].Maps[info.MapIndex];
                return map.Info.Name;
            }
            else
            {
                return "";
            }
        }

        private RealmsInfo GetRealmsInfo()
        {
            var x = int.Parse(lblXPos.Text);
            var y = int.Parse(lblYPos.Text);
            return _curMap.GetEditInfo(x, y);
        }

        private void HideEdge(bool force)
        {
            if (force || _curEdge != null)
            {
                lblEdgeDir.Text = "";
                lblEdgeMap.Text = "";
                lblEdgeMapX.Text = "";
                lblEdgeMapY.Text = "";

                if (_curEdge != null)
                {
                    var bitmap = (Bitmap)picMap.Image;
                    RealmsMap.DrawEdge(_curMap, _curEdge, _realmsData, bitmap, false);
                    picMap.Image = bitmap;
                }

                _curEdge = null;
            }
        }

        private void InfoFileDate()
        {
            try
            {
                var file = File.GetLastWriteTime($"{_realmsDir}\\{_infoFileName}");
                lblSaveNotes.Text = FormatSaveDate(file);
            }
            catch
            {
                lblSaveNotes.Text = "(new)";
            }
        }

        private void InitInventory()
        {
            LoadInv(cboIMain, _realmsData.Items, RealmsItem.IsMain);
            LoadInv(cboIOffhand, _realmsData.Items, RealmsItem.IsOffhand);
            LoadInv(cboIRanged, _realmsData.Items, RealmsItem.IsRanged);
            LoadInv(cboIAmmo, _realmsData.Items, RealmsItem.IsAmmo);
            LoadInv(cboIArmor, _realmsData.Items, RealmsItem.IsArmor);
            LoadInv(cboITrinket, _realmsData.Items, i => i[0] == (int)RealmsItemType.Trinket);
            LoadInv(cboISpellbook, _realmsData.Items, i => i[0] == (int)RealmsItemType.Book);

            LoadInv(cboIBackpack0, _realmsData.Items, i => true);
            LoadInv(cboIBackpack1, _realmsData.Items, i => true);
            LoadInv(cboIBackpack2, _realmsData.Items, i => true);
            LoadInv(cboIBackpack3, _realmsData.Items, i => true);
            LoadInv(cboIBackpack4, _realmsData.Items, i => true);
            LoadInv(cboIBackpack5, _realmsData.Items, i => true);
            LoadInv(cboIBackpack6, _realmsData.Items, i => true);
            LoadInv(cboIBackpack7, _realmsData.Items, i => true);
            LoadInv(cboIBackpack8, _realmsData.Items, i => true);
            LoadInv(cboIBackpack9, _realmsData.Items, i => true);
        }

        private void InitTabs(bool show)
        {
            tctlMain.Visible = show;
            mnuEdit.Enabled = show;
            mnuView.Enabled = show;
            if (show)
            {
                SetSelectedTab("tabWeapons");
            }
        }

        private void LoadApplicationSettings()
        {
            int.TryParse(ConfigurationManager.AppSettings["FormX"], out var formX);
            int.TryParse(ConfigurationManager.AppSettings["FormY"], out var formY);
            int.TryParse(ConfigurationManager.AppSettings["FormWidth"], out var formW);
            int.TryParse(ConfigurationManager.AppSettings["FormHeight"], out var formH);
            bool.TryParse(ConfigurationManager.AppSettings["FormMax"], out var formMax);
            if (!formMax)
            {
                if (formX != 0 || formY != 0)
                {
                    Location = new Point(formX, formY);
                }
                if (formW != 0 && formH != 0)
                {
                    Size = new Size(formW, formH);
                }
            }
            else
            {
                WindowState = FormWindowState.Maximized;
            }

            _infoFileName = ConfigurationManager.AppSettings["InfoFileName"];
            _realmsDir = ConfigurationManager.AppSettings["RealmsDir"];
        }

        private void LoadInv(ComboBox cbo, List<RealmsItem> items, Func<byte[], bool> check)
        {
            cbo.Items.Clear();
            cbo.Items.Add(new Tuple<string, string>("", "0,0"));
            cbo.SelectedIndex = 0;
            foreach (var cItem in items)
            {
                if (check(cItem.Data))
                {
                    cbo.Items.Add(new Tuple<string, string>(cItem.Name, $"{cItem.Data[0]},{cItem.Data[1]}"));
                }
            }
        }

        private void LoadInfoPanel()
        {
            lblInfoX.Text = _curInfo.X.ToString();
            lblInfoY.Text = _curInfo.Y.ToString();
            cboInfoType.SelectedIndex = (int)_curInfo.Type;
            lblInfoType.Text = (string)cboInfoType.Items[(int)_curInfo.Type];

            lblInfoMap.Text = GetMapName(_curInfo);
            lblInfoMapX.Text = _curInfo.MapX > -1 ? _curInfo.MapX.ToString() : "";
            lblInfoMapY.Text = _curInfo.MapY > -1 ? _curInfo.MapY.ToString() : "";
            txtInfoNotes.Text = _curInfo.Notes;

            btnInfoClose.Visible = _editMode;
            btnInfoDelete.Visible = _editMode;
            btnInfoMap.Visible = _editMode;
            cboInfoType.Visible = _editMode;
            lblInfoMapH.Visible = !_editMode;
            lblInfoType.Visible = !_editMode;
            txtInfoNotes.BackColor = _editMode ? SystemColors.Window : SystemColors.Control;

            pnlInfo.Visible = true;
        }

        private void LoadMobsForm()
        {
            _frmMobs.RealmsData = _realmsData;
            _frmMobs.RealmsMap = _curMap;
            _frmMobs.RealmsMapset = _realmsMaps.Mapsets[int.Parse(lblMapset.Text)];
            _frmMobs.LoadMobs();
        }

        private void LoadOptionsSettings()
        {
            var colors = ConfigurationManager.AppSettings["InfoColors"];
            var shows = ConfigurationManager.AppSettings["InfoShow"];
            foreach (var color in colors.Split('|'))
            {
                var fields = color.Split(',');
                if (fields.Length == 2)
                {
                    var t = int.Parse(fields[0]);
                    var c = Color.FromArgb(Convert.ToInt32(fields[1]));
                    _realmsData.Options.SetInfoColor((RealmsInfoType)t, c);
                }
            }
            foreach (var show in shows.Split('|'))
            {
                var fields = show.Split(',');
                if (fields.Length == 2)
                {
                    var t = int.Parse(fields[0]);
                    var s = bool.TryParse(fields[1], out var sh);
                    _realmsData.Options.SetShowInfo((RealmsInfoType)t, sh);
                }
            }
        }

        private void LoadPlayer(int index)
        {
            var file = File.GetLastWriteTime($"{_realmsDir}\\{RealmsParty.FileName}");
            lblPartyLoad.Text = FormatSaveDate(file);

            var player = _realmsData.Party.Players[index];
            txtPlayerName.Text = player.Name;
            cboClass.SelectedIndex = player.Stats.Class;
            nudActions.Value = player.Stats.Actions;
            nudMoves.Value = player.Stats.Moves;
            nudLevel.Value = player.Stats.Level;
            nudStrength.Value = player.Stats.Strength;
            nudAgility.Value = player.Stats.Agility;
            nudCunning.Value = player.Stats.Cunning;
            nudReason.Value = player.Stats.Reason;
            nudHealth.Value = player.Health.Health;
            nudWounds.Value = player.Health.Wounds;
            nudStamina.Value = player.Health.Stamina;
            nudFatigue.Value = player.Health.Fatigue;
            nudExpCurrent.Value = player.Stats.ExpCurrent;
            nudExpNext.Value = player.Stats.ExpNext;
            nudExpSkill.Value = player.Stats.ExpSkill;
            nudMelee.Value = player.Stats.Melee;
            nudRanged.Value = player.Stats.Ranged;
            nudSorcery.Value = player.Stats.Sorcery;
            nudDefense.Value = player.Stats.Defense;
            nudResist.Value = player.Stats.Resist;
            nudLore.Value = player.Stats.Lore;
            nudLocks.Value = player.Stats.Locks;
            nudTraps.Value = player.Stats.Traps;
            nudGamble.Value = player.Stats.Gamble;
            nudCritical.Value = player.Stats.Critical;
            nudARed.Value = player.Stats.ARed;
            nudAOrange.Value = player.Stats.AOrange;
            nudAYellow.Value = player.Stats.AYellow;
            nudAGreen.Value = player.Stats.AGreen;
            nudABlue.Value = player.Stats.ABlue;
            nudAIndigo.Value = player.Stats.AIndigo;
            nudAViolet.Value = player.Stats.AViolet;
            dgvPlayerStates.DataSource = player.States;
            SetInventory(index);
        }

        private bool LoadRealmsData()
        {
            try
            {
                InitTabs(false);
                _frmLoading.Show(this);
                Application.DoEvents();

                var pixelSize = int.Parse(ConfigurationManager.AppSettings["PixelSize"]);
                var shading = int.Parse(ConfigurationManager.AppSettings["Shading"]);
                var showGrid = bool.Parse(ConfigurationManager.AppSettings["ShowGrid"]);
                _realmsData = RealmsData.LoadData(_realmsDir, pixelSize, showGrid, shading);

                _realmsMaps = RealmsMaps.LoadMaps(_realmsDir, _realmsData, false, (s) => { _frmLoading.UpdateLoading(s); }, _infoFileName);
                _frmMap.Maps = RealmsMaps.LoadMaps(_realmsDir, _realmsData, true, (s) => { });

                return true;
            }
            catch (Exception ex)
            {
                _frmLoading.Hide();
                MessageBox.Show(ex.Message, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void ReloadParty()
        {
            _realmsData.Party = RealmsParty.LoadParty(_realmsDir, RealmsState.LoadStates(_realmsData.PData), _realmsData.Items);
            BuildParty();
        }

        private void ReloadMap()
        {
            _editMode = false;
            pnlInfo.Visible = false;
            HideEdge(true);
            BuildMap();
            LoadMobsForm();
        }

        private void SaveApplicationSettings()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            config.AppSettings.Settings["FormX"].Value = Location.X.ToString();
            config.AppSettings.Settings["FormY"].Value = Location.Y.ToString();
            config.AppSettings.Settings["FormWidth"].Value = Size.Width.ToString();
            config.AppSettings.Settings["FormHeight"].Value = Size.Height.ToString();
            config.AppSettings.Settings["FormMax"].Value = (WindowState == FormWindowState.Maximized).ToString();

            if (_realmsData != null)
            {
                config.AppSettings.Settings["RealmsDir"].Value = _realmsDir;
                config.AppSettings.Settings["PixelSize"].Value = _realmsData.Options.PixelSize.ToString();
                config.AppSettings.Settings["Shading"].Value = _realmsData.Options.Shading.ToString();
                config.AppSettings.Settings["ShowGrid"].Value = _realmsData.Options.ShowGrid.ToString();
            }

            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void SaveOptionsSettings()
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            var colors = string.Join("|", _realmsData.Options.GetInfoColors().Select(c => $"{(int)c.Key},{c.Value.ToArgb()}"));
            config.AppSettings.Settings["InfoColors"].Value = colors;

            var shows = string.Join("|", _realmsData.Options.GetShowInfos().Select(c => $"{(int)c.Key},{c.Value}"));
            config.AppSettings.Settings["InfoShow"].Value = shows;

            config.Save();
            ConfigurationManager.RefreshSection("appSettings");
        }

        private void SelectDataFolder()
        {
            dlgDataFolder.SelectedPath = _realmsDir;
            if (dlgDataFolder.ShowDialog() == DialogResult.OK)
            {
                _realmsDir = dlgDataFolder.SelectedPath;
                if (LoadRealmsData())
                {
                    LoadOptionsSettings();
                    SaveApplicationSettings();

                    BindRealmsData();
                    BuildCharsets();
                    BuildMaps();
                    BuildMap();
                    InitInventory();
                    BuildParty();

                    InitTabs(true);
                    _frmLoading.Hide();
                }
            }
        }

        private void SetArmorCompare()
        {
            foreach (DataGridViewRow row in dgvArmor.Rows)
            {
                row.Cells[4].Style = SetCellColor(_curArmor.Defense, (int)row.Cells[4].Value);
                row.Cells[5].Style = SetCellColor(_curArmor.Movement, (int)row.Cells[5].Value, true);
                row.Cells[6].Style = SetCellColor(_curArmor.Reduce, (int)row.Cells[6].Value);
                row.Cells[7].Style = SetCellColor(_curArmor.Resist, (int)row.Cells[7].Value);
                if (row.Index == 0)
                {
                    row.Frozen = true;
                }
            }
        }

        private void SetBackpack(ComboBox cbo, RealmsItem item, int back)
        {
            var bCbo = (ComboBox)(Controls.Find($"cboIBackpack{back}", true)[0]);
            var bNud = (NumericUpDown)(Controls.Find($"nudBack{back}", true)[0]);
            var index = 0;
            if (item != null)
            {
                var isAmmo = RealmsItem.IsAmmo(item.Data);
                var check = $"{item.Data[0]},{(isAmmo ? 0 : item.Data[1] & 31)}";
                foreach (var cItem in bCbo.Items)
                {
                    var cur = (Tuple<string, string>)cItem;
                    if (cur.Item2 == check)
                    {
                        break;
                    }
                    index++;
                }
                index = index < cbo.Items.Count ? index : 0;

                if (isAmmo)
                {
                    bNud.Value = item.Data[1];
                    bNud.Visible = true;
                }
                else
                {
                    bNud.Visible = false;
                }
            }
            else
            {
                bNud.Visible = false;
            }
            cbo.SelectedIndex = index;
        }

        private void SetInv(ComboBox cbo, RealmsItem item)
        {
            var index = 0;
            if (item != null)
            {
                var isAmmo = RealmsItem.IsAmmo(item.Data);
                var check = $"{item.Data[0]},{(isAmmo ? 0 : item.Data[1] & 31)}";
                foreach (var cItem in cbo.Items)
                {
                    var cur = (Tuple<string, string>)cItem;
                    if (cur.Item2 == check)
                    {
                        break;
                    }
                    index++;
                }
                index = index < cbo.Items.Count ? index : 0;
            }
            cbo.SelectedIndex = index;
        }

        private void SetInventory(int index)
        {
            var inventory = _realmsData.Party.Players[index].Inventory;
            SetInv(cboIMain, inventory.Main);
            SetInv(cboIOffhand, inventory.Offhand);
            SetInv(cboIRanged, inventory.Ranged);
            SetInv(cboIAmmo, inventory.Ammo);
            nudIAmmo.Value = inventory.Ammo != null ? inventory.Ammo.Data[1] : 0;
            SetInv(cboIArmor, inventory.Armor);
            SetInv(cboITrinket, inventory.Trinket);
            SetInv(cboISpellbook, inventory.Spellbook);

            SetBackpack(cboIBackpack0, inventory.Backpack[0], 0);
            SetBackpack(cboIBackpack1, inventory.Backpack[1], 1);
            SetBackpack(cboIBackpack2, inventory.Backpack[2], 2);
            SetBackpack(cboIBackpack3, inventory.Backpack[3], 3);
            SetBackpack(cboIBackpack4, inventory.Backpack[4], 4);
            SetBackpack(cboIBackpack5, inventory.Backpack[5], 5);
            SetBackpack(cboIBackpack6, inventory.Backpack[6], 6);
            SetBackpack(cboIBackpack7, inventory.Backpack[7], 7);
            SetBackpack(cboIBackpack8, inventory.Backpack[8], 8);
            SetBackpack(cboIBackpack9, inventory.Backpack[9], 9);
        }

        public void SetSelectedTab(string tabName)
        {
            tctlMain.SelectedTab = tctlMain.TabPages[tabName];
        }

        private DataGridViewCellStyle SetSpellColor(string spell)
        {
            switch (spell.ToLower())
            {
                case "red":
                    return new DataGridViewCellStyle { BackColor = System.Drawing.Color.Red, ForeColor = System.Drawing.Color.White };
                case "orange":
                    return new DataGridViewCellStyle { BackColor = System.Drawing.Color.Orange, ForeColor = System.Drawing.Color.Black };
                case "yellow":
                    return new DataGridViewCellStyle { BackColor = System.Drawing.Color.Yellow, ForeColor = System.Drawing.Color.Black };
                case "green":
                    return new DataGridViewCellStyle { BackColor = System.Drawing.Color.Green, ForeColor = System.Drawing.Color.White };
                case "blue":
                    return new DataGridViewCellStyle { BackColor = System.Drawing.Color.Blue, ForeColor = System.Drawing.Color.White };
                case "indigo":
                    return new DataGridViewCellStyle { BackColor = System.Drawing.Color.Indigo, ForeColor = System.Drawing.Color.White };
                case "violet":
                    return new DataGridViewCellStyle { BackColor = System.Drawing.Color.Violet, ForeColor = System.Drawing.Color.Black };
                default:
                    return new DataGridViewCellStyle { BackColor = System.Drawing.Color.White, ForeColor = System.Drawing.Color.Black };
            }
        }

        private List<RealmsArmor> SetArmorDataSource()
        {
            var source = new List<RealmsArmor> { _curArmor };
            source.AddRange(_realmsData.Armor.Where(a => a.Name != _curArmor.Name &&
                                                        (a.TypeName.ToLower().Contains(txtArmor.Text.ToLower()) ||
                                                         a.Name.ToLower().Contains(txtArmor.Text.ToLower()))).ToList());
            return source;
        }

        private DataGridViewCellStyle SetCellColor(int cur, int cell, bool inverse = false)
        {
            if (cell < cur)
            {
                return inverse ? new DataGridViewCellStyle { ForeColor = System.Drawing.Color.Black, BackColor = System.Drawing.Color.PaleGreen } :
                                 new DataGridViewCellStyle { ForeColor = System.Drawing.Color.Black, BackColor = System.Drawing.Color.LightCoral };
            }
            if (cell > cur)
            {
                return inverse ? new DataGridViewCellStyle { ForeColor = System.Drawing.Color.Black, BackColor = System.Drawing.Color.LightCoral } :
                                 new DataGridViewCellStyle { ForeColor = System.Drawing.Color.Black, BackColor = System.Drawing.Color.PaleGreen };
            }
            return new DataGridViewCellStyle { ForeColor = System.Drawing.Color.Black, BackColor = System.Drawing.Color.White };
        }

        private List<RealmsItem> SetItemDataSource()
        {
            return _realmsData.Items.Where(i => RealmsItem.IsItem(i.Data) && (i.TypeName.ToLower().Contains(txtItem.Text.ToLower()) ||
                                                i.Name.ToLower().Contains(txtItem.Text.ToLower()))).OrderBy(i => i.TypeName).ToList();
        }

        private List<SpellbookRow> SetSpellbookDataSource()
        {  
            return _realmsData.ToSpellbookRows().Where(s => s.BookName.ToLower().Contains(txtBook.Text.ToLower()) ||
                                                            s.SpellName.ToLower().Contains(txtBook.Text.ToLower())).OrderBy(s => s.BookName).ToList();
        }

        private List<RealmsSpell> SetSpellDataSource()
        {
            return _realmsData.Spells.Where(s => s.Name.ToLower().Contains(txtSpell.Text.ToLower())).OrderBy(s => s.Name).ToList();
        }

        private List<RealmsMonster> SetMonsterDataSource()
        {
            return _realmsData.Monsters.Where(m => m.Name.ToLower().Contains(txtMonster.Text.ToLower())).OrderBy(m => m.Name).ToList();
        }

        private void SetWeaponCompare()
        {
            foreach (DataGridViewRow row in dgvWeapons.Rows)
            {
                row.Cells[2].Style = SetCellColor(_curWeapon.Hit, (int)row.Cells[2].Value);
                row.Cells[3].Style = SetCellColor(_curWeapon.Action, (int)row.Cells[3].Value, true);
                row.Cells[4].Style = SetCellColor(_curWeapon.MinDmg, (int)row.Cells[4].Value);
                row.Cells[5].Style = SetCellColor(_curWeapon.MaxDmg, (int)row.Cells[5].Value);
                if (row.Index == 0)
                {
                    row.Frozen = true;
                }
            }
        }

        private List<RealmsWeapon> SetWeaponsDataSource()
        {
            var source = new List<RealmsWeapon> { _curWeapon };
            source.AddRange(_realmsData.Weapons.Where(w => w.Name != _curWeapon.Name &&
                                                           (w.TypeName.ToLower().Contains(txtWeapon.Text.ToLower()) ||
                                                            w.Name.ToLower().Contains(txtWeapon.Text.ToLower()))).ToList());
            return source;
        }

        private void ShowEdge(RealmsEdge edge)
        {
            if (_curEdge == null)
            {
                var map = _realmsMaps.Mapsets[edge.Set].Maps[edge.Index];
                lblEdgeDir.Text = edge.Dir.GetDescription();
                lblEdgeMap.Text = map.Info.Name;
                lblEdgeMapX.Text = edge.X.ToString();
                lblEdgeMapY.Text = edge.Y.ToString();

                var bitmap = (Bitmap)picMap.Image;
                RealmsMap.DrawEdge(_curMap, edge, _realmsData, bitmap, true);
                picMap.Image = bitmap;

                _curEdge = edge;
            }
        }

        private void ShowInfoPanels()
        {
            if (RealmsInfo.IsMapInfo(_curInfo.Type))
            {
                pnlInfoMap.Visible = true;
                pnlInfoNotes.Location = _notesPoint;
            }
            else
            {
                pnlInfoMap.Visible = false;
                pnlInfoNotes.Location = pnlInfoMap.Location;
            }
        }

        private void ShowMap(int set, int index, int x, int y)
        {
            var check = $"{set},{index}";
            var sindex = 0;
            foreach (var item in lstMaps.Items)
            {
                var tup = (Tuple<string, string>)item;
                if (tup.Item2 == check)
                {
                    lblXPos.Text = nudXPos.Value.ToString();
                    lblYPos.Text = nudYPos.Value.ToString();
                    _centerX = x;
                    _centerY = y;
                    
                    if (sindex == lstMaps.SelectedIndex)
                    {
                        ReloadMap();
                    }
                    else
                    {
                        lstMaps.SelectedIndex = sindex;
                    }
                    break;
                }
                sindex++;
            }
        }

        private void UpdatePlayer(int index)
        {
            _realmsData.Party.Money = (int)nudMoney.Value;
            _realmsData.Party.Rations = (int)nudRations.Value;
            _realmsData.Party.Mapset = (int)nudMapset.Value;
            _realmsData.Party.MapIndex = (int)nudMapIndex.Value;
            _realmsData.Party.X = (int)nudXPos.Value;
            _realmsData.Party.Y = (int)nudYPos.Value;
            _realmsData.Party.Light = (int)nudLight.Value;
            _realmsData.Party.LightInt = (int)nudLightInt.Value;
            _realmsData.Party.Stepwatch = (int)nudStepwatch.Value;
            _realmsData.Party.Stealth = (int)nudStealth.Value;
            _realmsData.Party.Sense = (int)nudSense.Value;

            var player = _realmsData.Party.Players[index];
            player.Name = txtPlayerName.Text;
            player.Stats.Level = (int)nudLevel.Value;
            player.Stats.Strength = (int)nudStrength.Value;
            player.Stats.Agility = (int)nudAgility.Value;
            player.Stats.Cunning = (int)nudCunning.Value;
            player.Stats.Reason = (int)nudReason.Value;
            player.Health.Health = (int)nudHealth.Value;
            player.Health.Wounds = (int)nudWounds.Value;
            player.Health.Stamina = (int)nudStamina.Value;
            player.Health.Fatigue = (int)nudFatigue.Value;
            player.Stats.Class = cboClass.SelectedIndex;
            player.Stats.ExpCurrent = (int)nudExpCurrent.Value;
            player.Stats.ExpNext = (int)nudExpNext.Value;
            player.Stats.ExpSkill = (int)nudExpSkill.Value;
            player.Stats.Melee = (int)nudMelee.Value;
            player.Stats.Ranged = (int)nudRanged.Value;
            player.Stats.Sorcery = (int)nudSorcery.Value;
            player.Stats.Defense = (int)nudDefense.Value;
            player.Stats.Resist = (int)nudResist.Value;
            player.Stats.Lore = (int)nudLore.Value;
            player.Stats.Locks = (int)nudLocks.Value;
            player.Stats.Traps = (int)nudTraps.Value;
            player.Stats.Gamble = (int)nudGamble.Value;
            player.Stats.Critical = (int)nudCritical.Value;
            player.Stats.ARed = (int)nudARed.Value;
            player.Stats.AOrange = (int)nudAOrange.Value;
            player.Stats.AYellow = (int)nudAYellow.Value;
            player.Stats.AGreen = (int)nudAGreen.Value;
            player.Stats.ABlue = (int)nudABlue.Value;
            player.Stats.AIndigo = (int)nudAIndigo.Value;
            player.Stats.AViolet = (int)nudAViolet.Value;

            player.Inventory.Main = UpdatePlayerInventory(cboIMain);
            player.Inventory.Offhand = UpdatePlayerInventory(cboIOffhand);
            player.Inventory.Ranged = UpdatePlayerInventory(cboIRanged);
            player.Inventory.Ammo = UpdatePlayerInventory(cboIAmmo, nudIAmmo);
            player.Inventory.Armor = UpdatePlayerInventory(cboIArmor);
            player.Inventory.Trinket = UpdatePlayerInventory(cboITrinket);
            player.Inventory.Spellbook = UpdatePlayerInventory(cboISpellbook);
            player.Inventory.Backpack = UpdatePlayerBackpack();
        }

        private List<RealmsItem> UpdatePlayerBackpack()
        {
            var items = new List<RealmsItem>();
            var index = 0;
            for (var b = 0; b < 10; b++)
            {
                var bCbo = (ComboBox)(Controls.Find($"cboIBackpack{b}", true)[0]);
                var selItem = (Tuple<string, string>)bCbo.SelectedItem;
                if (selItem != null)
                {
                    var values = selItem.Item2.Split(',');
                    var tItem = RealmsItem.Copy(int.Parse(values[0]), int.Parse(values[1]), _realmsData.Items);
                    if (tItem != null)
                    {
                        if (RealmsItem.IsAmmo(tItem.Data))
                        {
                            var bNud = (NumericUpDown)(Controls.Find($"nudBack{b}", true)[0]);
                            if (bNud != null)
                            {
                                tItem.Data[1] = Convert.ToByte(bNud.Value);
                            }
                        }
                        items.Add(tItem);
                        index++;
                    }
                }
            }

            for(var t = 0; t < 10 - index; t++)
            {
                items.Add(null);
            }

            return items;
        }

        private RealmsItem UpdatePlayerInventory(ComboBox cboItem, NumericUpDown nudItem = null)
        {
            var selItem = (Tuple<string, string>)cboItem.SelectedItem;
            if (selItem != null)
            {
                var values = selItem.Item2.Split(',');
                var tItem = RealmsItem.Copy(int.Parse(values[0]), int.Parse(values[1]), _realmsData.Items);
                if (tItem != null && nudItem != null)
                {
                    tItem.Data[1] = Convert.ToByte(nudItem.Value);
                }
                return tItem;
            }
            return null;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Text = $"RoA Companion ({Application.ProductVersion})";

            // Load AppSettings
            LoadApplicationSettings();

            // Initalize Information panels
            InitTabs(false);
            HideEdge(true);
            pnlInfo.Visible = false;
            _notesPoint = pnlInfoNotes.Location;
            foreach (var info in Enum.GetValues(typeof(RealmsInfoType)))
            {
                var rit = (RealmsInfoType)info;
                if (rit != RealmsInfoType.Marker)
                {
                    cboInfoType.Items.Add(rit.GetDescription());
                }
            }

            // Setup double buffering for DataGridViews
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvArmor, new object[] { true });
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvWeapons, new object[] { true });
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvSpells, new object[] { true });
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvBooks, new object[] { true });
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvMonsters, new object[] { true });
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvItems, new object[] { true });
            typeof(DataGridView).InvokeMember("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty, null, dgvPlayerStates, new object[] { true });
        }

        private void btnInfoClose_Click(object sender, EventArgs e)
        {
            _editMode = false;
            pnlInfo.Visible = false;
        }

        private void btnInfoDelete_Click(object sender, EventArgs e)
        {
            RealmsMapInfo.DeleteMapInfo(_curInfo, _curMap, _realmsMaps);
            _editMode = false;
            pnlInfo.Visible = false;
            BuildMap();
        }

        private void btnInfoMap_Click(object sender, EventArgs e)
        {
            _frmMap.Text = $"Map Select - From {txtMapName.Text} X:{lblInfoX.Text} Y:{lblInfoY.Text}";

            _frmMap.RealmsData = _realmsData;
            _frmMap.MapNames = _mapNames;
            _frmMap.Mapset = _curInfo.Mapset;
            _frmMap.MapIndex = _curInfo.MapIndex;
            _frmMap.MapX = _curInfo.MapX;
            _frmMap.MapY = _curInfo.MapY;

            _frmMap.StartPosition = FormStartPosition.CenterParent;
            _frmMap.ShowDialog();

            if (_frmMap.Selected)
            {
                _curInfo.Mapset = _frmMap.Mapset;
                _curInfo.MapIndex = _frmMap.MapIndex;
                _curInfo.MapX = _frmMap.MapX;
                _curInfo.MapY = _frmMap.MapY;

                lblInfoMap.Text = _frmMap.MapName;
                lblInfoMapX.Text = _frmMap.MapX.ToString();
                lblInfoMapY.Text = _frmMap.MapY.ToString();
            }

            if (_frmMap.Clear)
            {
                _curInfo.Mapset = -1;
                _curInfo.MapIndex = -1;
                _curInfo.MapX = -1;
                _curInfo.MapY = -1;

                lblInfoMap.Text = "";
                lblInfoMapX.Text = "";
                lblInfoMapY.Text = "";
            }
        }

        private void btnMoveToMap_Click(object sender, EventArgs e)
        {
            _frmMap.RealmsData = _realmsData;
            _frmMap.MapNames = _mapNames;
            _frmMap.Mapset = (int)nudMapset.Value;
            _frmMap.MapIndex = (int)nudMapIndex.Value;
            _frmMap.MapX = (int)nudXPos.Value;
            _frmMap.MapY = (int)nudYPos.Value;

            _frmMap.ShowClear = false;
            _frmMap.StartPosition = FormStartPosition.CenterParent;
            _frmMap.ShowDialog();

            if (_frmMap.Selected)
            {
                nudMapset.Value = _frmMap.Mapset;
                nudMapIndex.Value = _frmMap.MapIndex;
                nudXPos.Value = _frmMap.MapX;
                nudYPos.Value = _frmMap.MapY;
            }
        }

        private void btnReloadPlayer_Click(object sender, EventArgs e)
        {
            ReloadParty();
        }

        private void btnSaveNotes_Click(object sender, EventArgs e)
        {
            lblSaveNotes.Text = FormatSaveDate(RealmsMapInfo.SaveMapInfo(_realmsDir, _infoFileName, _realmsMaps));
        }

        private void btnSavePlayer_Click(object sender, EventArgs e)
        {
            UpdatePlayer(cboPlayer.SelectedIndex);
            RealmsParty.SaveParty(_realmsData.Party, _realmsDir);
            lblPartyLoad.Text = FormatSaveDate(DateTime.Now);
            ReloadParty();
        }

        private void btnShowMap_Click(object sender, EventArgs e)
        {
            SetSelectedTab("tabMaps");
            ShowMap((int)nudMapset.Value, (int)nudMapIndex.Value, (int)nudXPos.Value, (int)nudYPos.Value);
        }

        private void cboCurArmor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurArmor.Focused)
            {
                _curArmor = _realmsData.Armor[cboCurArmor.SelectedIndex];
                dgvArmor.DataSource = SetArmorDataSource();
                SetArmorCompare();
            }
        }

        private void cboCurWeapon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboCurWeapon.Focused)
            {
                _curWeapon = _realmsData.Weapons[cboCurWeapon.SelectedIndex];
                dgvWeapons.DataSource = SetWeaponsDataSource();
                SetWeaponCompare();
            }
        }

        private void cboIBackpack0_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack0.Focused)
            {
                BackpackAmmo(0);
            }
        }

        private void cboIBackpack1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack1.Focused)
            {
                BackpackAmmo(1);
            }
        }

        private void cboIBackpack2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack2.Focused)
            {
                BackpackAmmo(2);
            }
        }

        private void cboIBackpack3_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack3.Focused)
            {
                BackpackAmmo(3);
            }
        }

        private void cboIBackpack4_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack4.Focused)
            {
                BackpackAmmo(4);
            }
        }

        private void cboIBackpack5_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack5.Focused)
            {
                BackpackAmmo(5);
            }
        }

        private void cboIBackpack6_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack6.Focused)
            {
                BackpackAmmo(6);
            }
        }

        private void cboIBackpack7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack7.Focused)
            {
                BackpackAmmo(7);
            }
        }

        private void cboIBackpack8_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack8.Focused)
            {
                BackpackAmmo(8);
            }
        }

        private void cboIBackpack9_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboIBackpack9.Focused)
            {
                BackpackAmmo(9);
            }
        }

        private void cboInfoType_SelectedIndexChanged(object sender, EventArgs e)
        {
            _curInfo.Type = (RealmsInfoType)cboInfoType.SelectedIndex;
            ShowInfoPanels();
            BuildMap();
        }

        private void cboPlayer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboPlayer.Focused)
            {
                UpdatePlayer(_prevPlayer);
                LoadPlayer(cboPlayer.SelectedIndex);
            }
            _prevPlayer = cboPlayer.SelectedIndex;
        }

        private void dgvBooks_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dgvBooks.Rows[e.RowIndex];
                var color = SetSpellColor((string)row.Cells[2].Value);
                row.Cells[2].Style = color;
            }
        }

        private void dgvSpells_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                var row = dgvSpells.Rows[e.RowIndex];
                var color = SetSpellColor((string)row.Cells[1].Value);
                row.Cells[1].Style = color;
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveApplicationSettings();
        }

        private void lstChars_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblCSet.Text = lstChars.SelectedIndex.ToString();
            lblCharIndex.Text = "0";
            BuildCharset(_realmsData);
        }

        private void lstMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            ReloadMap();
        }

        private void mnuDataFolder_Click(object sender, EventArgs e)
        {
            SelectDataFolder();
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnuFind_Click(object sender, EventArgs e)
        {
            _frmFind.RealmsData = _realmsData;
            _frmFind.RealmsMaps = _realmsMaps;
            _frmFind.MapNames = _mapNames;
            _frmFind.StartPosition = FormStartPosition.CenterParent;
            if (_frmFind.ShowDialog() == DialogResult.OK)
            {
                SetSelectedTab("tabMaps");
                ShowMap(_frmFind.MapSet, _frmFind.MapIndex, _frmFind.MapX, _frmFind.MapY);
            }
        }

        private void mnuMobs_Click(object sender, EventArgs e)
        {
            SetSelectedTab("tabMaps");
            if (!_frmMobs.Visible)
            {
                _frmMobs.Show(this);
            }
        }

        private void mnuOptions_Click(object sender, EventArgs e)
        {
            _frmOptions.FormMain = this;
            _frmOptions.Options = _realmsData.Options;
            _frmOptions.StartPosition = FormStartPosition.CenterParent;
            if (_frmOptions.ShowDialog() == DialogResult.OK)
            {
                SaveOptionsSettings();
            }
        }

        private void nudLight_ValueChanged(object sender, EventArgs e)
        {
            if (nudLight.Focused)
            {
                nudLightInt.Value = nudLight.Value == 0 ? 0 : nudLightInt.Value;
                nudLightInt.Value = nudLight.Value > 0 && nudLightInt.Value == 0 ? 3 : nudLightInt.Value;
            }
        }

        private void nudLightInt_ValueChanged(object sender, EventArgs e)
        {
            if (nudLightInt.Focused)
            {
                nudLight.Value = nudLightInt.Value == 0 ? 0 : nudLight.Value;
                nudLight.Value = nudLightInt.Value > 0 && nudLight.Value == 0 ? 10 : nudLight.Value;
            }
        }

        private void picCharset_MouseMove(object sender, MouseEventArgs e)
        {
            lblCharIndex.Text = RealmsChar.CalcCharsetIndex(e.X, e.Y, _realmsData).ToString();
        }

        private void picMap_Click(object sender, EventArgs e)
        {
            var me = (MouseEventArgs)e;
            if (me.Button == MouseButtons.Left && lblXPos.Text != "")
            {
                _curInfo = GetRealmsInfo();
                _editMode = true;
                LoadInfoPanel();
                BuildMap();
            }

            if (me.Button == MouseButtons.Right)
            {
                if (_curInfo != null)
                {
                    var x = int.Parse(lblXPos.Text);
                    var y = int.Parse(lblYPos.Text);
                    var info = RealmsMapInfo.GetInfo(x, y, _curMap.Info, _realmsData.Options);

                    if (info != null && RealmsInfo.IsMapInfo(info.Type))
                    {
                        var check = $"{info.Mapset},{info.MapIndex}";
                        var index = 0;
                        foreach (var item in lstMaps.Items)
                        {
                            var tup = (Tuple<string, string>)item;
                            if (tup.Item2 == check)
                            {
                                lblXPos.Text = info.MapX.ToString();
                                lblYPos.Text = info.MapY.ToString();
                                _centerX = info.MapX;
                                _centerY = info.MapY;

                                if (index == lstMaps.SelectedIndex)
                                {
                                    ReloadMap();
                                }
                                else
                                {
                                    lstMaps.SelectedIndex = index;
                                }
                                break;
                            }
                            index++;
                        }
                    }
                }
                else if (_curEdge != null)
                {
                    var check = $"{_curEdge.Set},{_curEdge.Index}";
                    var index = 0;
                    foreach (var item in lstMaps.Items)
                    {
                        var tup = (Tuple<string, string>)item;
                        if (tup.Item2 == check)
                        {
                            lblXPos.Text = _curEdge.X.ToString();
                            lblYPos.Text = _curEdge.Y.ToString();
                            _centerX = _curEdge.X;
                            _centerY = _curEdge.Y;
                            if (index == lstMaps.SelectedIndex)
                            {
                                ReloadMap();
                            }
                            else
                            {
                                lstMaps.SelectedIndex = index;
                            }
                            break;
                        }
                        index++;
                    }
                }
            }
        }

        private void picMap_MouseLeave(object sender, EventArgs e)
        {
            HideEdge(false);
            _curX = -1;
            _curY = -1;
        }

        private void picMap_MouseMove(object sender, MouseEventArgs e)
        {
            _curMap.Coords(e.X, e.Y, out var x, out var y, _realmsData.Options);
            if (x != _curX || y != _curY)
            {
                lblXPos.Text = x > -1 ? x.ToString() : "";
                lblYPos.Text = y.ToString();
                _curX = x;
                _curY = y;

                if (!_editMode)
                {
                    if (x > -1 && y != -1)
                    {
                        var info = RealmsMapInfo.GetInfo(x, y, _curMap.Info, _realmsData.Options);
                        if (info != null)
                        {
                            _curInfo = info;
                            LoadInfoPanel();
                        }
                        else
                        {
                            _curInfo = null;
                            pnlInfo.Visible = false;
                        }
                    }
                }

                if (_curInfo == null)
                {
                    var edge = RealmsEdge.GetEdge(_curMap, x, y);
                    if (edge != null && _realmsData.Options.GetShowInfo(RealmsInfoType.Map))
                    {
                        ShowEdge(edge);
                    }
                    else
                    {
                        HideEdge(false);
                    }
                }
            }
        }

        private void txtArmor_TextChanged(object sender, EventArgs e)
        {
            dgvArmor.DataSource = SetArmorDataSource();
            SetArmorCompare();
        }

        private void txtBook_TextChanged(object sender, EventArgs e)
        {
            dgvBooks.DataSource = SetSpellbookDataSource();
        }

        private void txtInfoNotes_TextChanged(object sender, EventArgs e)
        {
            _curInfo.Notes = txtInfoNotes.Text;
        }

        private void txtItem_TextChanged(object sender, EventArgs e)
        {
            dgvItems.DataSource = SetItemDataSource();
        }

        private void txtMonster_TextChanged(object sender, EventArgs e)
        {
            dgvMonsters.DataSource = SetMonsterDataSource();
        }

        private void txtSpell_TextChanged(object sender, EventArgs e)
        {
            dgvSpells.DataSource = SetSpellDataSource();
        }

        private void txtMapName_TextChanged(object sender, EventArgs e)
        {
            if (txtMapName.Focused)
            {
                _curMap.Info.Name = txtMapName.Text;
                _mapNames[lstMaps.SelectedIndex] = new Tuple<string, string>(txtMapName.Text, $"{_curMap.Set},{_curMap.Index}");
                _mapNames.ResetBindings();
            }
        }

        private void txtWeapon_TextChanged(object sender, EventArgs e)
        {
            dgvWeapons.DataSource = SetWeaponsDataSource();
            SetWeaponCompare();
        }

        private void txtPlayerName_TextChanged(object sender, EventArgs e)
        {
            if (txtPlayerName.Focused)
            {
                var index = cboPlayer.SelectedIndex;
                _realmsData.Party.Players[index].Name = txtPlayerName.Text;

                cboPlayer.Items.Clear();
                foreach (var player in _realmsData.Party.Players)
                {
                    cboPlayer.Items.Add(player.Name);
                }
                cboPlayer.SelectedIndex = index;
            }
        }
    }
}
