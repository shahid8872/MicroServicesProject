using AutoMapper;
using Mango.Services.CouponeAPI.Models;
using Mango.Services.CouponeAPI.Models.DTO;

namespace Mango.Services.CouponeAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
