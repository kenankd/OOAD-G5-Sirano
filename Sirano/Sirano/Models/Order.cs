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
        public int Id { get; set; }
        public string OrderDate { get; set; }
        public string DeliveryDate { get; set; }
        public string Status { get; set; }
        public PaymentMethod PaymentMethod { get; set; }
        [ForeignKey("Cart")]
        public int CartID { get; set; }
        public Cart Cart { get; set; }
        //public object Cart { get; internal set; }

        public Order() { }
    }
}
