using DriveMe.Domain.Common;

namespace DriveMe.Domain
{
    public class RideRequest : BaseDomainEntity
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
