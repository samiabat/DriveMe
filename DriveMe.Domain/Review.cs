using DriveMe.Domain.Common;

namespace DriveMe.Domain
{
    public class Review : BaseDomainEntity
    {
        public int ReviewerId { get; set; }
        public int RevieweeeId { get; set; }
        public float Rating { get; set; }
        public string ReviewText { get; set; }
    }
}
