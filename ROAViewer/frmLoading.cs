using System;
using System.Windows.Forms;

namespace ROAViewer
{
    public partial class frmLoading : Form
    {
        public frmLoading()
        {
            InitializeComponent();
        }

        public void UpdateLoading(string text)
        {
            lblLoading.Text = text;
            Application.DoEvents();
        }

        private void frmLoading_Load(object sender, EventArgs e)
        {
            CenterToParent();
        }
    }
}
