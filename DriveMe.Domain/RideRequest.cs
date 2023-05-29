using DriveMe.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveMe.Domain
{
    public class RideRequest: BaseDomainEntity
    {
        public int PassengerId { get; set; }
        public int DriverId { get; set; }
        public string PickUpLocation { get; set; }
        public string Destination { get; set; }
        public string RideStatus { get; set; }
        public float Price { get; set; }
        public string PaymentStatus { get; set; }
    }
}
