using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyShop.Data.Entities;

namespace MyShop.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Add seed data and save changes
        }

        public static void CreateUserRoles(IServiceProvider serviceProvider)
        {
            var roleManager = serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();
            var userManager = serviceProvider.GetRequiredService<UserManager<AppUser>>();
            string[] roleNames = { "Admin", "Manager", "Member" };

            foreach (var roleName in roleNames)
            {
                var roleExisted = roleManager.RoleExistsAsync(roleName).Result;

                if (!roleExisted)
                {
                    roleManager.CreateAsync(new IdentityRole(roleName)).Wait();
                }
            }

            //Asign Admin role to the main User here i have given my login id for Admin management 
            //var adminUser = userManager.FindByEmailAsync("admin@gmail.com").Result;
            //var managerUser = userManager.FindByEmailAsync("admin@gmail.com").Result;

            var adminUser = new AppUser
            {
                Email = "admin@gmail.com",
                UserName = "admin@gmail.com"
            };
            var managerUser = new AppUser
            {
                Email = "manager@gmail.com",
                UserName = "manager@gmail.com"
            };

            var createdAdminUser = userManager.CreateAsync(adminUser, "Abcd@123").Result;
            if(createdAdminUser.Succeeded)
                userManager.AddToRoleAsync(adminUser, "Admin").Wait();

            var createdManagerUser = userManager.CreateAsync(managerUser, "Abcd@123").Result;
            if (createdManagerUser.Succeeded)
                userManager.AddToRoleAsync(managerUser, "Manager").Wait();
        }
    }
}