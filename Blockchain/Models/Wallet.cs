namespace Blockchain.Models
{
    public class WalletResponse
    {
        public string Guid { get; set; }
        public string Address { get; set; }
        public string Label { get; set; }
    }

    public class WalletRequest
    {
        public string Password { get; set; }
        public string ApiCode { get; set; }
        public string PrivateKey { get; set; }
        public string Label { get; set; }
        public string Email { get; set; }
    }
}
