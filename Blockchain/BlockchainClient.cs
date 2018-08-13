using Blockchain.Models;
using RestSharp;

namespace Blockchain
{
    public class BlockchainClient
    {
        public BlockchainClient() { }

        public WalletResponse CreateNewAddress(WalletRequest wallet)
        {
            var request = new RestRequest("/api/v2/create", Method.POST);

            request.AddParameter("password", wallet.Password);
            request.AddParameter("api_code", wallet.ApiCode);
            request.AddParameter("priv", wallet.PrivateKey);
            request.AddParameter("label", wallet.Label);
            request.AddParameter("email", wallet.Email);

            return BlockchainApi.Execute<WalletResponse>(request);
        }
    }
}