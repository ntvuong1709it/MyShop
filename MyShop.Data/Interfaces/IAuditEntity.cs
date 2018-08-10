using System;

namespace MyShop.Data.Interfaces
{
    public interface IAuditEntity
    {
        string CreatedBy { get; set; }
        DateTime? CreatedDateOnUtc { get; set; }
        string ModifiedBy { get; set; }
        DateTime? ModifiedDateOnUtc { get; set; }
    }
}