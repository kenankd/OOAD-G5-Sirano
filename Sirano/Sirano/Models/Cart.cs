using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sirano.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        public ICollection<Product> Product { get; set; } = new List<Product>();
        
        [ForeignKey("RegisteredUser")]
        public int UserID { get; set; }

        public RegisteredUser RegisteredUser { get; set; }
        public string Size { get; set; }    
        public Cart() { }
    }
}
