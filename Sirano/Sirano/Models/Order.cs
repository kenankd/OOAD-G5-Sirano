using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace Sirano.Models
{
    public class Order
    {
        [Key]
        public int id { get; set; }
        public string orderDate { get; set; }
        public string deliveryDate { get; set; }
        public string status { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        [ForeignKey("Cart")]
        public int CartID { get; set; }
        public Cart cart { get; set; }
        //public object Cart { get; internal set; }

        public Order() { }
    }
}
