namespace Hakaton.Core
{
    public class RoomUpsertDto : BaseUpsertDto
    {
        public string Name { get; set; } = null!;

        public int HomeId { get; set; }
    }
}
