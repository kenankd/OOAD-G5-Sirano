namespace Sirano.Models
{
    public class Footwear: Product
    {
        public int id { get; set; }
        public string size { get; set; }
        public FootwearCategory category { get; set; }
        public Footwear() { }
    }
}
