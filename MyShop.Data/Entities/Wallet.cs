using System;

namespace MyShop.Data.Entities
{
    public class Wallet
    {
        public int Id { get; set; }
        public Guid Guid { get; set; }
        public string Address { get; set; }
        public string Label { get; set; }

        public string CustomerId { get; set; }
        public Customer Customer { get; set; }
    }
}
