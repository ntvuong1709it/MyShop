using System;
using MyShop.Data.Interfaces;

namespace MyShop.Data.Entities
{
    public class Item : IEntity<int>, IAuditEntity, IDeleteEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public bool Visible { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDateOnUtc { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateOnUtc { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDateOnUtc { get; set; }
    }
}