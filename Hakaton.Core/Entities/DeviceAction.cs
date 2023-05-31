namespace Hakaton.Core
{
    public class DeviceAction : BaseEntity
    {
        public string SettingName { get; set; } = null!;
        public string SettingValue { get; set; } = null!;
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

        public int DeviceId { get; set; }
        public Device Device { get; set; } = null!;

        public int UserId { get; set; }
        public User User { get; set; } = null!;
    }
}
