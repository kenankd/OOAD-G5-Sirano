using System.ComponentModel.DataAnnotations;

namespace Sirano.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public User() { }
    }
}
