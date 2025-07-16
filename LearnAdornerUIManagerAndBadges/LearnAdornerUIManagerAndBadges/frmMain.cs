using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnAdornerUIManagerAndBadges
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }
        int email = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            badge1.Properties.Text = (++email).ToString();
            badge1.Visible = true;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            badge1.Visible = false;
            timer1.Start();
        }

        private void mail_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (email == 0)
            {
                return;
            }
            badge1.Properties.Text = (--email).ToString();
            if (email == 0)
            {
                badge1.Visible = false;
            }
            XtraForm1 fm = new XtraForm1();
            fm.MdiParent = this;
            fm.Show();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }
    }
}