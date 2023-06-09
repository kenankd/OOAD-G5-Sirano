using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sirano.Models
{
    public class Review
    {
        [Key]
        public int Id { get; set; }
        public double Rating { get; set; }
        public string Comment { get; set; }
        [ForeignKey("Product")]
        public int ProductID { get; set; }
        public Product Product { get; set; }
        public Review() { }
    }
}
