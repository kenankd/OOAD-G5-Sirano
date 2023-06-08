using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sirano.Models
{
    public abstract class Product
    {
        [Key]
        public int Id { get; set; }
        public string Price { get; set; }
        public string Colour { get; set; }
        public string Image { get; set; }
        public string Name { get; set; }
        public Boolean Men { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart? Cart { get; set; }

        public string Summary { get; set; }

        public Product(){}
}
}
