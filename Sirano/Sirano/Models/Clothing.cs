using System.ComponentModel.DataAnnotations;

namespace Sirano.Models
{
    public class Clothing: Product
    {
        public string size { get; set; }
        public ClothingCategory category { get; set; }
        public Clothing() { }

    }
}
