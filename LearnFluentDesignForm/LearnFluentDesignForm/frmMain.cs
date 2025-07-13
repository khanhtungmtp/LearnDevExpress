using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LearnFluentDesignForm
{
    public partial class frmMain : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {

        }

        private void accordionCategory_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucCategory.Instance))
            {
             container.Controls.Add(ucCategory.Instance);
                ucCategory.Instance.Dock = DockStyle.Fill;
                ucCategory.Instance.BringToFront();
            }
            ucCategory.Instance.BringToFront();
        }

        private void accordionProducts_Click(object sender, EventArgs e)
        {
            if (!container.Controls.Contains(ucProducts.Instance))
            {
                container.Controls.Add(ucProducts.Instance);
                ucProducts.Instance.Dock = DockStyle.Fill;
                ucProducts.Instance.BringToFront();
            }
            ucProducts.Instance.BringToFront();
        }
    }
}
