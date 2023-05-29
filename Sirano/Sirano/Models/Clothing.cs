using System.ComponentModel.DataAnnotations;

namespace Sirano.Models
{
    public class Clothing: Product
    {
        [Key]
        public int id { get; set; }
        public string size { get; set; }
        public ClothingCategory category { get; set; }
        public Clothing() { }
    }
}
