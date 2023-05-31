namespace Hakaton.Core
{
    public class DeviceDto : BaseDto
    {
        public string Description { get; set; } = null!;
        public string? DevicePhoto { get; set; }

        public int DeviceTypeId { get; set; }
        public DeviceTypeDto DeviceType { get; set; } = null!;

        public int RoomId { get; set; }
        public RoomDto Room { get; set; } = null!;
    }
}
