using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace LearnPrintInvoice
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
        public XtraReport1()
        {
            InitializeComponent();
        }

        private void xrTableCell2_BeforePrint(object sender, CancelEventArgs e)
        {

        }

        public void InitData(string orderid, DateTime orderdate, string customer, string address, string postcode, string city, string phone, List<OrdersDetail> data)
        {
            pInvoiceID.Value = orderid;
            pDate.Value = orderdate.Date;
            pCustomerName.Value = customer;
            pAddress.Value = address;
            pPostalCode.Value = postcode;
            pCity.Value = city;
            pPhone.Value = phone;
            bindingSource3.DataSource = data;
        }

    }
}
