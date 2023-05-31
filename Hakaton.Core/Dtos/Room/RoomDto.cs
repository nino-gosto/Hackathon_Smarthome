namespace Hakaton.Core
{
    public class RoomDto : BaseDto
    {
        public string Name { get; set; } = null!;

        public int HomeId { get; set; }
        public HomeDto Home { get; set; } = null!;
    }
}
