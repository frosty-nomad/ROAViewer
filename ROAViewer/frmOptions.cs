using Realms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ROAViewer
{
    public partial class frmOptions : Form
    {
        public frmMain FormMain { get; set; }
        public RealmsOptions Options { get; set; }

        private RealmsOptions _options;
        private int origPixelSize;

        public frmOptions()
        {
            InitializeComponent();
        }

        private void CopyOptions()
        {
            _options = new RealmsOptions(Options.PixelSize, Options.ShowGrid, Options.Shading);
            foreach(var show in Options.GetShowInfos())
            {
                _options.SetShowInfo(show.Key, show.Value);
            }
            foreach(var color in Options.GetInfoColors())
            {
                _options.SetInfoColor(color.Key, color.Value);
            }
        }

        private void RefreshMap(bool charUpdate = false)
        {
            FormMain.SetSelectedTab("tabMaps");
            if (charUpdate)
            {
                FormMain.BuildChars();
            }
            FormMain.BuildMap();
        }

        private void RestoreOptions()
        {
            Options.PixelSize = _options.PixelSize;
            Options.ShowGrid = _options.ShowGrid;
            Options.Shading = _options.Shading;
            foreach (var show in _options.GetShowInfos())
            {
                Options.SetShowInfo(show.Key, show.Value);
            }
            foreach(var color in _options.GetInfoColors())
            {
                Options.SetInfoColor(color.Key, color.Value);
            }
        }

        private void InitOptions()
        {
            FormMain.SetSelectedTab("tabMaps");
            CopyOptions();

            chkInfo.Checked = Options.GetShowInfo(RealmsInfoType.Info);
            chkMap.Checked = Options.GetShowInfo(RealmsInfoType.Map);
            chkVendor.Checked = Options.GetShowInfo(RealmsInfoType.Vendor);
            chkNPC.Checked = Options.GetShowInfo(RealmsInfoType.NPC);
            chkDoor.Checked = Options.GetShowInfo(RealmsInfoType.Door);
            chkBoat.Checked = Options.GetShowInfo(RealmsInfoType.Boat);
            chkSecret.Checked = Options.GetShowInfo(RealmsInfoType.Secret);
            chkChest.Checked = Options.GetShowInfo(RealmsInfoType.Chest);
            chkTrap.Checked = Options.GetShowInfo(RealmsInfoType.Trap);
            chkPitTrap.Checked = Options.GetShowInfo(RealmsInfoType.PitTrap);
            chkMonster.Checked = Options.GetShowInfo(RealmsInfoType.Monster);
            chkQuest.Checked = Options.GetShowInfo(RealmsInfoType.Quest);
            chkShowGrid.Checked = Options.ShowGrid;
            nudPixelSize.Value = Options.PixelSize;
            tbarShading.Value = Options.Shading;
            origPixelSize = Options.PixelSize;

            SetColor(RealmsInfoType.Info, btnInfo);
            SetColor(RealmsInfoType.Map, btnMap);
            SetColor(RealmsInfoType.Vendor, btnVendor);
            SetColor(RealmsInfoType.NPC, btnNPC);
            SetColor(RealmsInfoType.Door, btnDoor);
            SetColor(RealmsInfoType.Boat, btnBoat);
            SetColor(RealmsInfoType.Secret, btnSecret);
            SetColor(RealmsInfoType.Chest, btnChest);
            SetColor(RealmsInfoType.Trap, btnTrap);
            SetColor(RealmsInfoType.PitTrap, btnPitTrap);
            SetColor(RealmsInfoType.Monster, btnMonster);
            SetColor(RealmsInfoType.Quest, btnQuest);
        }

        private void PickColor(RealmsInfoType type, Button button)
        {
            colorDialog1.Color = button.BackColor;
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Options.SetInfoColor(type, colorDialog1.Color);
                SetColor(type, button);
                RefreshMap();
            }
        }

        private void SetColor(RealmsInfoType type, Button button)
        {
            button.BackColor = Options.GetInfoColor(type);
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {
            InitOptions();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            RestoreOptions();
            RefreshMap(origPixelSize != nudPixelSize.Value);
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnInfo_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Info, btnInfo);
        }

        private void btnMap_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Map, btnMap);
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Vendor, btnVendor);
        }

        private void btnNPC_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.NPC, btnNPC);
        }

        private void btnDoor_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Door, btnDoor);
        }

        private void btnBoat_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Boat, btnBoat);
        }

        private void btnSecret_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Secret, btnSecret);
        }

        private void btnChest_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Chest, btnChest);
        }

        private void btnTrap_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Trap, btnTrap);
        }

        private void btnPitTrap_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.PitTrap, btnPitTrap);
        }

        private void btnMonster_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Monster, btnMonster);
        }

        private void btnQuest_Click(object sender, EventArgs e)
        {
            PickColor(RealmsInfoType.Quest, btnQuest);
        }

        private void chkInfo_CheckedChanged(object sender, EventArgs e)
        {
            if (chkInfo.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Info, chkInfo.Checked);
                RefreshMap();
            }
        }

        private void chkMap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMap.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Map, chkMap.Checked);
                RefreshMap();
            }
        }

        private void chkVendor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkVendor.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Vendor, chkVendor.Checked);
                RefreshMap();
            }
        }

        private void chkNPC_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNPC.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.NPC, chkNPC.Checked);
                RefreshMap();
            }
        }

        private void chkDoor_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDoor.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Door, chkDoor.Checked);
                RefreshMap();
            }
        }

        private void chkBoat_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBoat.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Boat, chkBoat.Checked);
                RefreshMap();
            }
        }

        private void chkSecret_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSecret.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Secret, chkSecret.Checked);
                RefreshMap();
            }
        }

        private void chkChest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkChest.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Chest, chkChest.Checked);
                RefreshMap();
            }
        }

        private void chkTrap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTrap.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Trap, chkTrap.Checked);
                RefreshMap();
            }
        }

        private void chkPitTrap_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPitTrap.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.PitTrap, chkPitTrap.Checked);
                RefreshMap();
            }
        }

        private void chkMonster_CheckedChanged(object sender, EventArgs e)
        {
            if (chkMonster.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Monster, chkMonster.Checked);
                RefreshMap();
            }
        }

        private void chkQuest_CheckedChanged(object sender, EventArgs e)
        {
            if (chkQuest.Focused)
            {
                Options.SetShowInfo(RealmsInfoType.Quest, chkQuest.Checked);
                RefreshMap();
            }
        }

        private void nudPixelSize_ValueChanged(object sender, EventArgs e)
        {
            Options.PixelSize = (int)nudPixelSize.Value;
            RefreshMap(true);
        }

        private void tbarShading_ValueChanged(object sender, EventArgs e)
        {
            Options.Shading = tbarShading.Value;
            RefreshMap();
        }

        private void chkShowGrid_CheckedChanged(object sender, EventArgs e)
        {
            Options.ShowGrid = chkShowGrid.Checked;
            RefreshMap();
        }
    }
}
