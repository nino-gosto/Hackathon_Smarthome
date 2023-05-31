namespace Hakaton.Core
{
    public class DeviceActionDto : BaseDto
    {
        public string SettingName { get; set; } = null!;
        public string SettingValue { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int DeviceId { get; set; }
        public DeviceDto Device { get; set; } = null!;

        public int UserId { get; set; }
        public UserDto User { get; set; } = null!;
    }
}
