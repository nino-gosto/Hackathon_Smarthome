using Hakaton.Core;

namespace Hakaton.Application
{
    public class RoomProfile : BaseProfile
    {
        public RoomProfile()
        {
            CreateMap<RoomDto, Room>().ReverseMap();

            CreateMap<RoomUpsertDto, Room>();
        }
    }
}
