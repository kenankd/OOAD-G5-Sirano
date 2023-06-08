using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sirano.Models
{
    public abstract class Product
    {
        [Key]
        public int id { get; set; }
        public string price { get; set; }
        public string colour { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public Boolean men { get; set; }
        [ForeignKey("Cart")]
        public int CartId { get; set; }
        public Cart? Cart { get; set; }

        public string summary { get; set; }

        public Product(){}
}
}
