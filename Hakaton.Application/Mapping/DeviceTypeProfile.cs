using Hakaton.Core;

namespace Hakaton.Application
{
    public class DeviceTypeProfile : BaseProfile
    {
        public DeviceTypeProfile()
        {
            CreateMap<DeviceTypeDto, DeviceType>().ReverseMap();

            CreateMap<DeviceTypeUpsertDto, DeviceType>();
        }
    }
}
