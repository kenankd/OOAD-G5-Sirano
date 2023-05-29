using Microsoft.VisualBasic;
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
        [ForeignKey("Product")]
        public int productID { get; set; }
        public Product products { get; set; }
        public double price { get; set; }
        public string status { get; set; }
        public PaymentMethod paymentMethod { get; set; }
        [ForeignKey("User")]
        public int userID { get; set; }
        public User user { get; set; }
        public Order() { }
    }
}
