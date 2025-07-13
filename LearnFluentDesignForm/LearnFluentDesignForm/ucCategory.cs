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
    public partial class ucCategory : DevExpress.XtraEditors.XtraUserControl
    {
        public static ucCategory _Instance;
        public static ucCategory Instance
        {
            get
            {
                if (_Instance == null)
                    _Instance = new ucCategory();
                return _Instance;
            }
        }
        public ucCategory()
        {
            InitializeComponent();
        }

        private void ucCategory_Load(object sender, EventArgs e)
        {
            var categories = new List<Category>
            {
                new Category { CategoryID = 1, CategoryName = "Thực phẩm" },
                new Category { CategoryID = 2, CategoryName = "Đồ uống" },
                new Category { CategoryID = 3, CategoryName = "Đồ dùng văn phòng" }
            };
            gridControl2.DataSource = categories;
        }
    }
}
