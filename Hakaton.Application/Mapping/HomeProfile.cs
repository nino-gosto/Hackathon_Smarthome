using Hakaton.Core;

namespace Hakaton.Application
{
    public class HomeProfile : BaseProfile
    {
        public HomeProfile()
        {
            CreateMap<HomeDto, Home>().ReverseMap();

            CreateMap<HomeUpsertDto, Home>();
        }
    }
}
