using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using MyShop.Data.Entities;

namespace MyShop.Data.Interfaces
{
    public interface IApplicationDbContext
    {
        int SaveChanges();
        DbSet<T> Set<T>() where T:class;
        DbSet<Category> Categories { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<Order> Orders { get; set; }
        DbSet<OrderDetail> OrderDetails { get; set; }
    }
}
