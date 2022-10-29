using Realms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ROAViewer
{
    public partial class frmMap : Form
    {
        public RealmsData RealmsData { get; set; }
        public RealmsMaps Maps { get; set; }
        public BindingList<Tuple<string, string>> MapNames { get; set; }
        public string MapName { get; set; }
        public int Mapset { get; set; }
        public int MapIndex { get; set; }
        public int MapX { get; set; }
        public int MapY { get; set; }
        public bool Clear { get; set; }
        public bool Selected { get; set; }
        public bool ShowClear { get; set; } = true;

        private RealmsMap _curMap;
        private int _curX = -1;
        private int _curY = -1;
        private int _prevX = -1;
        private int _prevY = -1;

        public frmMap()
        {
            InitializeComponent();
        }

        private void frmMap_Load(object sender, EventArgs e)
        {
            lstMaps.DataSource = MapNames;

            Clear = false;
            Selected = false;

            if (Mapset < 0)
            {
                Mapset = 0;
                MapIndex = 0;
            }
            lstMaps.SelectedIndex = GetSelectedIndex();
            btnClear.Visible = ShowClear;

            LoadMap();
        }

        private int GetSelectedIndex()
        {
            var check = $"{Mapset},{MapIndex}";
            var index = 0;
            foreach (var item in lstMaps.Items)
            {
                var cur = (Tuple<string, string>)item;
                if (cur.Item2 == check)
                {
                    return index;
                }
                index++;
            }
            return 0;
        }

        private void LoadMap()
        {
            _curMap = new RealmsMap(Maps.Mapsets[Mapset].Maps[MapIndex]);
            if (MapX > -1 && MapY > -1)
            {
                _curMap.Info.Info.Add(new RealmsInfo
                {
                    Type = RealmsInfoType.Marker,
                    X = MapX,
                    Y = MapY
                });
            }

            var bitmap = RealmsMap.BuildBitmap(_curMap, RealmsData);
            picMap.Width = bitmap.Width;
            picMap.Height = bitmap.Height;
            picMap.Image = bitmap;

            lblMapset.Text = Mapset.ToString();
            lblMapIndex.Text = MapIndex.ToString();
            lblXPos.Text = MapX.ToString();
            lblYPos.Text = MapY.ToString();

            splitContainer1.Panel2.HorizontalScroll.Value = 0;
            splitContainer1.Panel2.VerticalScroll.Value = 0;
        }

        private void picMap_MouseMove(object sender, MouseEventArgs e)
        {
            var coords = e.Location;
            _curMap.Coords(coords.X, coords.Y, out _curX, out _curY, RealmsData.Options);

            if (_curX != _prevX || _curY != _prevY)
            {
                var dChar = _curMap.Type == RealmsMapType.Indoor ? 56 : 56 + RealmsData.Party.Players.Count;
                var bitmap = picMap.Image;
                using (var g = Graphics.FromImage(bitmap))
                {
                    if (_prevX != -1 && _prevY != -1)
                    {
                        RealmsMap.DrawTile(_curMap, _prevX, _prevY, RealmsData, g);
                    }
                    if (_curX != -1 && _curY != -1)
                    {
                        var tSize = RealmsMap.CalcTileSize(RealmsData.Options);
                        g.DrawImage(RealmsData.GetChar(1, dChar).Bitmap, RealmsMap.CalcBitmapX(_curMap, _curX, _curY, tSize), _curY * tSize);
                    }
                }
                picMap.Image = bitmap;

                lblXPos.Text = _curX > -1 ? _curX.ToString() : "";
                lblYPos.Text = _curY.ToString();
             
                _prevX = _curX;
                _prevY = _curY;
            }
        }

        private void picMap_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && lblXPos.Text != "")
            {
                MapName = ((Tuple<string, string>)lstMaps.SelectedItem).Item1;
                MapX = int.Parse(lblXPos.Text);
                MapY = int.Parse(lblYPos.Text);
                Selected = true;
                Close();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear = true;
            Close();
        }

        private void frmMap_FormClosing(object sender, FormClosingEventArgs e)
        {
            splitContainer1.Panel2.VerticalScroll.Value = 0;
            splitContainer1.Panel2.HorizontalScroll.Value = 0;
        }

        private void lstMaps_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstMaps.Focused)
            {
                var item = (Tuple<string, string>)lstMaps.SelectedItem;
                var values = item.Item2.Split(',');
                MapName = item.Item1;
                Mapset = int.Parse(values[0]);
                MapIndex = int.Parse(values[1]);
                LoadMap();
            }
        }
    }
}
