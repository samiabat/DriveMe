using DriveMe.Domain.Common;

namespace DriveMe.Domain
{
    public class Car : BaseDomainEntity
    {
        public string VihcleType { get; set; }
        public string Vihcle_Plate_Number { get; set; }
    }
}
