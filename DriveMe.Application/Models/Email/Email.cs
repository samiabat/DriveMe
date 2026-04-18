using System.ComponentModel.DataAnnotations;

namespace DriveMe.Application.Models.Email
{
    public class Email
    {
        [EmailAddress]
        public string To { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }
    }
}
