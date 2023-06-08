using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace Sirano.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Products { get; set; }
        public Store() { }
    }
}
