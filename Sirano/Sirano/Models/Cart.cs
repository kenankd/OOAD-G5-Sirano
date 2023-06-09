using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sirano.Models
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("RegisteredUser")]
        public int UserID { get; set; }

        public RegisteredUser RegisteredUser { get; set; }
        public string Size { get; set; }
        public Boolean Bought { get; set; }
        public Cart() { }
    }
}

