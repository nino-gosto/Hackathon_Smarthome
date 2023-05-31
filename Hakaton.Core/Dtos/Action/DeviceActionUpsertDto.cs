namespace Hakaton.Core
{
    public class DeviceActionUpsertDto : BaseUpsertDto
    {
        public string SettingName { get; set; } = null!;
        public string SettingValue { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int DeviceId { get; set; }

        public int UserId { get; set; }
    }
}
