using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sirano.Models
{
    public class Review
    {
        [Key]
        public int id { get; set; }
        public double rating { get; set; }
        public string comment { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }  
        public Product Product { get; set; }   
        public Review() { }
    }
}
