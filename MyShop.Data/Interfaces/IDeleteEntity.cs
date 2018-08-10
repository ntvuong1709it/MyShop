using System;

namespace MyShop.Data.Interfaces
{
    public interface IDeleteEntity
    {
        bool IsDeleted { get; set; }
        string DeletedBy { get; set; }
        DateTime? DeletedDateOnUtc { get; set; }
    }
}