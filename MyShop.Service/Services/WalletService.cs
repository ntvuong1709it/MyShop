using System.Transactions;
using MyShop.Data.Entities;
using MyShop.Repository.Interfaces;
using MyShop.Service.Interfaces;

namespace MyShop.Service.Services
{
    public class WalletService : IWalletService
    {
        private readonly IWalletRepository _walletRepository;

        public WalletService(IWalletRepository walletRepository)
        {
            _walletRepository = walletRepository;
        }

        public void AddWallet(Wallet wallet)
        {
            _walletRepository.Add(wallet);
            _walletRepository.SaveChanges();
        }
    }
}