using AutoMapper;
using MyShop.Data.Entities;
using MyShop.Service.Models;

namespace MyShop.Service.Configuration.Mapping
{
    public static class ConfigMapping
    {
        public static void Run()
        {
            Mapper.Initialize(cfg =>
            {
                MapCategory(cfg);
            });
            
        }

        private static void MapCategory(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CategoryAddModel, Category>();
        }
    }
}
