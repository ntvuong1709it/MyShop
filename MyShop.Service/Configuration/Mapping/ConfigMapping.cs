using AutoMapper;
using Blockchain.Models;
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
                MapWallet(cfg);
            });
            
        }

        private static void MapCategory(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<CategoryAddModel, Category>();
        }

        private static void MapWallet(IMapperConfigurationExpression cfg)
        {
            cfg.CreateMap<WalletResponse, Wallet>();
        }
    }
}
