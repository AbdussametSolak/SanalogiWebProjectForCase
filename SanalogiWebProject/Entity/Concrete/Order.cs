using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Order
    {
        // Veritabanımızda siparisler tablomuza karsılık
        // gelen classımız


        //Database first calısacagız.
        public int orderId { get; set; }
        public string orderDate { get; set; }

        public string companyName { get; set; }
        public int productQuantity { get; set; } //urun adeti
        public string productName { get; set; }
        public double productPrice { get; set; } 
    }
}
