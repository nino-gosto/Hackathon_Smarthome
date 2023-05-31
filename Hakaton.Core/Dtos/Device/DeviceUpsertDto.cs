namespace Hakaton.Core
{
    public class DeviceUpsertDto : BaseUpsertDto
    {
        public string Description { get; set; } = null!;
        public string? DevicePhoto { get; set; }

        public int DeviceTypeId { get; set; }

        public int RoomId { get; set; }
    }
}
