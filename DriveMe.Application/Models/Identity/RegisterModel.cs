using System.ComponentModel.DataAnnotations;

namespace DriveMe.Application.Models.Identity
{
    public class RegisterModel
    {
        [EmailAddress]
        public string Email { get; set; }

        [MinLength(10)]
        public string Password { get; set; }

        public string FullName { get; set; }
        public ICollection<string> Roles { get; set; }
    }
}
