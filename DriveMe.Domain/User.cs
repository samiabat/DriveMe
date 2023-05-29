using DriveMe.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Domain
{
    public class User: BaseDomainEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public bool IsVerified { get; set; }
        public string PassportNo { get; set; } = "";
        public int Car { get; set; } = 0;
        public string DriveLicenceNo { get; set; } = "";
    }
}
