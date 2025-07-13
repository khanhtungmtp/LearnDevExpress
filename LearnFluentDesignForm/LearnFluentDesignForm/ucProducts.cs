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
            // Dữ liệu tĩnh giả lập
            List<Product> mockProducts = new List<Product>()
            {
                new Product { ProductID = 1, ProductName = "Chai nước suối", QuantityPerUnit = "12 chai", UnitPrice = 5.5m },
                new Product { ProductID = 2, ProductName = "Bánh quy", QuantityPerUnit = "10 hộp", UnitPrice = 15.0m },
                new Product { ProductID = 3, ProductName = "Sữa tươi", QuantityPerUnit = "24 hộp", UnitPrice = 22.3m }
            };
            gridControl1.DataSource = mockProducts;
        }
    }
}
