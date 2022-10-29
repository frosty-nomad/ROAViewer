using Realms;
using System;
using System.Windows.Forms;

namespace ROAViewer
{
    public partial class frmMobs : Form
    {
        public RealmsData RealmsData { get; set; }
        public RealmsMap RealmsMap { get; set; }
        public RealmsMapset RealmsMapset { get; set; }

        public frmMobs()
        {
            InitializeComponent();
        }

        public void LoadMobs()
        {
            lstMobs.Items.Clear();
            foreach (var mob in RealmsMap.Mobs.Mobs)
            {
                lstMobs.Items.Add(mob.Type.GetDescription());
            }
            ClearDetails();
            lstMobs.SelectedIndex = RealmsMap.Mobs.Mobs.Count > 1 ? 0 : -1;
        }

        private void ClearDetails()
        {
            lblMobType.Text = "";
            lblMobChar.Text = "";
            lblMobXPos.Text = "";
            lblMobYPos.Text = "";
            lblMobData0.Text = "";
            lblMobData1.Text = "";
            lblMobData2.Text = "";
            lblMobData3.Text = "";
            lblData0Text.Text = "";
            lblData1Text.Text = "";
            lblData2Text.Text = "";
            lblData3Text.Text = "";
            picMobChar.Image = null;
        }

        private void SetDetails()
        {
            var cur = RealmsMap.Mobs.Mobs[lstMobs.SelectedIndex];
            lblMobType.Text = cur.Type.GetDescription();
            lblMobChar.Text = $"({cur.Char})";
            lblMobXPos.Text = cur.X.ToString();
            lblMobYPos.Text = cur.Y.ToString();
            lblMobData0.Text = cur.Data[0].ToString();
            lblMobData1.Text = cur.Data[1].ToString();
            lblMobData2.Text = cur.Data[2].ToString();
            lblMobData3.Text = cur.Data[3].ToString();

            var mChar = RealmsMob.GetChar(cur, RealmsMap.Charset, RealmsData);
            if (mChar != null)
            {
                picMobChar.Height = mChar.Bitmap.Height;
                picMobChar.Width = mChar.Bitmap.Width;
                picMobChar.Image = mChar.Bitmap;
            }
            else
            {
                picMobChar.Image = null;
            }

            var texts = RealmsMobs.GetMobTexts(cur, RealmsMap.Mobs.Texts, RealmsData);
            lblData0Text.Text = texts[0];
            lblData1Text.Text = texts[1];
            lblData2Text.Text = texts[2];
            lblData3Text.Text = texts[3];

            var trans = RealmsMobs.GetMobTransactions(cur, RealmsMapset);
            lblTransaction.Text = trans[0];
            lblDOffset.Text = trans[1];
            txtTransaction.Text = trans[2];
        }

        private void lstMobs_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDetails();
        }

        private void frmMobs_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                Hide();
            }
        }

        private void frmMobs_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
