using System.ComponentModel.DataAnnotations;

namespace Sirano.Models
{
    public class Clothing: Product
    {
        public ClothingCategory category { get; set; }
        public Clothing() { }

    }
}
