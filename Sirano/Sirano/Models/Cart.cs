using System.ComponentModel.DataAnnotations.Schema;

namespace Sirano.Models
{
    public class Cart
    {
        public int Id { get; set; }
        [ForeignKey("Product")]
        public int productID { get; set; }
        [ForeignKey("User")]
        public int userID { get; set; }
    }
}
