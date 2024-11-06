using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyStore.Models.ViewModel
{
    public class CartItem
    {
       public int ProductID { get; set; }
        public string Productname { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string ProductImage { get; set; }
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}