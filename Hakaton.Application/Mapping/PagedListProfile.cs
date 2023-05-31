using Hakaton.Core;

namespace Hakaton.Application
{
    public class PagedListProfile : BaseProfile
    {
        public PagedListProfile()
        {
            CreateMap(typeof(PagedList<>), typeof(PagedList<>));
        }
    }
}
