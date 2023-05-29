using DriveMe.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Domain
{
    public class Car: BaseDomainEntity
    {
        public string VihcleType { get; set; }
        public string Vihcle_Plate_Number { get; set; }
    }
}
