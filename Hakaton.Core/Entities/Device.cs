namespace Hakaton.Core
{
    public class Device : BaseEntity
    {
        public string Description { get; set; } = null!;
        public string? DevicePhoto { get; set; }

        public int DeviceTypeId { get; set; }
        public DeviceType DeviceType { get; set; } = null!;

        public int RoomId { get; set; }
        public Room Room { get; set; } = null!;

        public ICollection<DeviceAction> DeviceActions { get; set; } = null!;
    }
}
