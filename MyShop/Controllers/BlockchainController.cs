using Blockchain;
using Blockchain.Models;
using Microsoft.AspNetCore.Mvc;

namespace MyShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlockchainController : ControllerBase
    {
        private readonly BlockchainClient _blockchainClient;
        public BlockchainController()
        {
            _blockchainClient = new BlockchainClient();
        }

        [HttpPost]
        public IActionResult CreateNewWallet(WalletRequest wallet)
        {
            var createdWallet = _blockchainClient.CreateNewAddress(wallet);
            return Ok();
        }
    }
}