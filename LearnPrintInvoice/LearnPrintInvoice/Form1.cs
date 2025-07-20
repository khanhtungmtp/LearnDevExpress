using Dapper;
using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace LearnPrintInvoice
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Orders obj = ordersBindingSource.Current as Orders;
            if (obj != null)
            {
                using (IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["cn"].ConnectionString))
                {
                    if (db.State == ConnectionState.Closed)
                        db.Open();
                    string query = "select d.OrderID, p.ProductName, d.Quantity, d.Discount, d.UnitPrice from [Order Details] d " +
                        "inner join Products p on d.ProductID = p.ProductID" +
                                    $" where d.OrderID = '{obj.OrderId}'";
                    List<OrdersDetail> list = db.Query<OrdersDetail>(query, commandType: CommandType.Text).ToList();
                    // Open print form dialog
                    using (frmPrint frm = new frmPrint())
                    {
                        frm.PrintInvoice(obj, list);
                        frm.ShowDialog();
                    }
                }
            }
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
