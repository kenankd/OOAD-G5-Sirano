using System.ComponentModel.DataAnnotations;

namespace Sirano.Models
{
    public class Review
    {
        [Key]
        public int id { get; set; }
        public double rating { get; set; }
        public string comment { get; set; }
        public Review() { }
    }
}
