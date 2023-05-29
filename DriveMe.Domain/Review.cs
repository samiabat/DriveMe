using DriveMe.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Domain
{
    public class Review: BaseDomainEntity
    {
        public int ReviewerId { get; set; }
        public int RevieweeeId { get; set; }
        public float Rating { get; set; }
        public string ReviewText { get; set; }
    }
}
