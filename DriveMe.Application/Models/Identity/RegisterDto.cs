﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Application.Models.Identity
{
    public class RegisterDto
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public ICollection<string> Roles { get; set; }
    }
}
