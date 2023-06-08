using System.ComponentModel.DataAnnotations;

namespace Sirano.Models
{
    public class Clothing: Product
    {
        public ClothingCategory Category { get; set; }
        public Clothing() { }

    }
}
