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

namespace LearnPrintInvoice
{
    public partial class frmPrint : DevExpress.XtraEditors.XtraForm
    {
        public frmPrint()
        {
            InitializeComponent();
        }
        public void PrintInvoice(Orders order, List<OrdersDetail> data)
        {
            XtraReport1 report = new XtraReport1();
            foreach (DevExpress.XtraReports.Parameters.Parameter p in report.Parameters)
                p.Visible = false;

            report.InitData(order.OrderId.ToString(), order.OrderDate, order.ContactName, order.Address, order.PostalCode, order.City, order.Phone, data);
            documentViewer1.DocumentSource = report;
            report.CreateDocument();
        }

    }
}