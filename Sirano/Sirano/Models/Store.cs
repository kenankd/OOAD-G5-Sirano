using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Net.Http.Headers;

namespace Sirano.Models
{
    public class Store
    {
        [Key]
        public int id { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        [ForeignKey("Product")]
        public int productID { get; set; }
        public Product products { get; set; }
        public Store() { }
    }
}
