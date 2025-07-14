using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnFluentDesignForm
{
    public partial class ucProducts : DevExpress.XtraEditors.XtraUserControl
    {
        public static ucProducts _Instance;
        public static ucProducts Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucProducts();
                return _Instance;
            }
        }
        public ucProducts()
        {
            InitializeComponent();
        }

        private void gridControl1_Load(object sender, EventArgs e)
        {
            NORTHWNDEntities2 db = new NORTHWNDEntities2();
            gridControl1.DataSource = db.Products.ToList();
        }
    }
}
