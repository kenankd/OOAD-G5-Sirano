namespace Sirano.Models
{
    public class Footwear: Product
    {
        public string size { get; set; }
        public FootwearCategory category { get; set; }
        public Footwear() { }
    }
}
