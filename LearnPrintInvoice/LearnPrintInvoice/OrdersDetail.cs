using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnPrintInvoice
{
    public class OrdersDetail
    {
        public int OrderId { get; set; }
        [Display(Name = "Product Name")]
        public string ProductName { get; set; }
        [Display(Name = "Unit price")]
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal Discount { get; set; }
        public decimal TotalPrice => UnitPrice * Quantity - Quantity * UnitPrice * Discount ;
        public OrdersDetail(int orderId, string productName, decimal unitPrice, int quantity, decimal discount)
        {
            OrderId = orderId;
            ProductName = productName;
            UnitPrice = unitPrice;
            Quantity = quantity;
            Discount = discount;
        }
    }
}
