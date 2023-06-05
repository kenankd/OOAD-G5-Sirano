using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sirano.Models
{
    public abstract class Product
    {
        [Key]
        public int id { get; set; }
        public double discount { get; set; }
        [ForeignKey("Review")]
        public int reviewID { get; set; }
        public Review review { get; set; }
        public string price { get; set; }
        public string colour { get; set; }
        public string image { get; set; }
        public string name { get; set; }
        public Boolean men { get; set; }

        public string summary { get; set; }

        public Product(){}
}
}
