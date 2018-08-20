﻿using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MyShop.Data.Entities;

namespace MyShop.Data
{
    public static class DbInitializer
    {
        public static void Initialize(ApplicationDbContext context)
        {
            
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
            };
            var managerUser = new AppUser
            {
                Email = "manager@gmail.com",
            };

            userManager.AddToRoleAsync(adminUser, "Admin").Wait();
            userManager.AddToRoleAsync(managerUser, "Manager").Wait();
        }
    }
}