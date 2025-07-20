using Dapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LearnPrintInvoice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
            {
                if (db.State == ConnectionState.Closed)
                    db.Open();
                string query = "select o.OrderID, c.CustomerID, c.ContactName, c.Address, c.PostalCode, c.City, c.Phone, o.OrderDate" +
                               " from Orders o inner join Customers c on o.CustomerID = c.CustomerID" +
                               $" where o.OrderDate between convert(varchar(25),'{dateEdit1.EditValue}',103) and convert(varchar(25),'{dateEdit2.EditValue}',103)";
                ordersBindingSource.DataSource = db.Query<Orders>(query, commandType: CommandType.Text);
            }
        }
    }
}
