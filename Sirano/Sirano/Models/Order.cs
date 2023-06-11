using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

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

        public string? CardNumber { get; set; }
        public int? ExpirationMonth { get; set; }
        public int? ExpirationYear { get; set; }
        public string? Cardholder { get; set; }
        public int? CVV { get; set; }


        public Order() { }
    }
}