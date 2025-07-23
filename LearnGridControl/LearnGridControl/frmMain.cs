using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnGridControl
{
    public partial class frmMain : DevExpress.XtraEditors.XtraForm
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Categories' table. You can move, or remove it, as needed.
            this.categoriesTableAdapter.Fill(this.nORTHWNDDataSet.Categories);
            // TODO: This line of code loads data into the 'nORTHWNDDataSet.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.nORTHWNDDataSet.Products);

        }
    }
}