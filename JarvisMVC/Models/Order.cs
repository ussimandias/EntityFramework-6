using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace JarvisMVC.Models
{
    public class Order
    {
        [Key]
        public int OrderID { get; set; }
        public DateTime OrderDate { get; set; }
        public Customer Customer { get; set; }
        public int Amount { get; set; }
        public string Location { get; set; }
    }
}