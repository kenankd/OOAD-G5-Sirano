using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;
namespace Sirano.Models
{
    public class RegisteredUser
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public RegisteredUser() { }
    }
}