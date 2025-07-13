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

namespace LearnRibbonControl
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void module1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule1 frm = new frmModule1();
            frm.MdiParent = this;
            frm.Show();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule2 frm = new frmModule2();
            frm.MdiParent = this;
            frm.Show();

        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmModule3 frm = new frmModule3();
            frm.MdiParent = this;
            frm.Show();

        }
    }
}