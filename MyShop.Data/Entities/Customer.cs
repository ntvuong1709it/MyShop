using System;
using MyShop.Data.Enum;
using MyShop.Data.Interfaces;

namespace MyShop.Data.Entities
{
    public class Customer : IEntity<int>, IAuditEntity, IDeleteEntity
    {
        public int Id { get; set; }
        public string IdentityId { get; set; }
        public AppUser Identity { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string District { get; set; }
        public string Ward { get; set; }
        public string City { get; set; }
        public string ShippingAddress { get; set; }
        public string ShippingDistrict { get; set; }
        public string ShippingWard { get; set; }
        public string ShippingCity { get; set; }


        public string CreatedBy { get; set; }
        public DateTime? CreatedDateOnUtc { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateOnUtc { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDateOnUtc { get; set; }
        public Wallet Wallet { get; set; }
    }
}
