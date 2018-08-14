using System.Security.Claims;
using AutoMapper;
using Blockchain;
using Blockchain.Models;
using Microsoft.AspNetCore.Mvc;
using MyShop.Data.Entities;
using MyShop.Service.Interfaces;

namespace MyShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockchainController : ControllerBase
    {
        private readonly BlockchainClient _blockchainClient;
        private readonly IWalletService _walletService;

        public BlockchainController(IWalletService walletService)
        {
            _blockchainClient = new BlockchainClient();
            _walletService = walletService;
        }

        [HttpPost]
        [Route("NewWallet")]
        public IActionResult CreateNewWallet(WalletRequest walletRequest)
        {
            var createdWallet = _blockchainClient.CreateNewAddress(walletRequest);

            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);

            var wallet = Mapper.Map<Wallet>(createdWallet);
            wallet.CustomerId = userId;

            _walletService.AddWallet(wallet);

            return Ok();
        }
    }
}