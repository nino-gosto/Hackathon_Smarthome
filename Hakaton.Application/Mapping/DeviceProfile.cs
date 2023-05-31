using Hakaton.Core;

namespace Hakaton.Application
{
    public class DeviceProfile : BaseProfile
    {
        public DeviceProfile()
        {
            CreateMap<DeviceDto, Device>().ReverseMap();

            CreateMap<DeviceUpsertDto, Device>();
        }
    }
}
