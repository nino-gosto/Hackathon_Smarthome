namespace Hakaton.Core
{
    public class HomeDto : BaseDto
    {
        public string Name { get; set; } = null!;
        public string Address { get; set; } = null!;
        public HomeType Type { get; set; }

        public int UserId { get; set; }
        public UserDto User { get; set; } = null!;
    }
}
