namespace MyShop.Service.Models
{
    public class NewProductModel
    {
        public string Name { get; set; }
        public string Sku { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public bool? OnSale { get; set; }
        public int? TotalSale { get; set; }
        public int StockQuantity { get; set; }
        public string Weight { get; set; }
    }
}