using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using MyShop.Data.Interfaces;

namespace MyShop.Data.Entities
{
    public class Product : IEntity<int>, IAuditEntity ,IDeleteEntity
    {
        public Product()
        {
            IsDeleted = false;
            CreatedDateOnUtc = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal? SalePrice { get; set; }
        public DateTime? DateSaleFromUtc { get; set; }
        public DateTime? DateSaleToUtc { get; set; }
        public int? TotalSale { get; set; }
        public bool OnSale { get; set; }
        public string Sku { get; set; }
        public int StockQuantity { get; set; }
        public string Status { get; set; } // Publish, draft. Default is Pushlish
        public string Weight { get; set; }
        public float? AverageRating { get; set; }
        public int? RatingCount { get; set; }
        public string ImageUrl { get; set; }

        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDateOnUtc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateOnUtc { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateOnUtc { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}