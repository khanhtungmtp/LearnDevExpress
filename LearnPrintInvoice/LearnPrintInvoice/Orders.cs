using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnPrintInvoice
{
    public class Orders
    {
        public int OrderId { get; set; }
        public string CustomerId { get; set; }
        [Display(Name = "Contact Name")]
        public string ContactName { get; set; }
        public string Address { get; set; } 
        public decimal TotalAmount { get; set; }
        [Display(Name = "Postal Code")]
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public DateTime OrderDate { get; set; }
    }
}
