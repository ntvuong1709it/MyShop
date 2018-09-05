using MyShop.Data.Interfaces;

namespace MyShop.Data.Entities
{
    public class OrderDetail : IEntity<int>
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }

        public int OrderId { get; set; }
        public Order Order { get; set; }
    }
}