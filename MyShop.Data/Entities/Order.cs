using System;
using MyShop.Data.Interfaces;

namespace MyShop.Data.Entities
{
    public class Order : IEntity<int>, IAuditEntity, IDeleteEntity
    {
        public int Id { get; set; }
        public string Number { get; set; }
        public string Status { get; set; }
        public string Note { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedDateOnUtc { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateOnUtc { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDateOnUtc { get; set; }

        public OrderDetail OrderDetail { get; set; }
    }
}