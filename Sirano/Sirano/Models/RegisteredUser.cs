using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace Sirano.Models
{
    public class RegisteredUser
    {
        [Key]
        public int Id { get; set; }
        public string fullName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public RegisteredUser() { }
    }
}