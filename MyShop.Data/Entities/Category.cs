using System;
using System.Collections;
using System.Collections.Generic;
using MyShop.Data.Interfaces;

namespace MyShop.Data.Entities
{
    public class Category : IEntity<int>, IAuditEntity, IDeleteEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string CreatedBy { get; set; }
        public DateTime? CreatedDateOnUtc { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDateOnUtc { get; set; }
        public bool IsDeleted { get; set; }
        public string DeletedBy { get; set; }
        public DateTime? DeletedDateOnUtc { get; set; }

        public ICollection<ProductCategory> ProductCategories { get; set; }
    }
}