﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MyShop.Data;

namespace MyShop.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20180905034141_UpdateModel")]
    partial class UpdateModel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("MyShop.Data.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("MyShop.Data.Entities.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedDateOnUtc");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDateOnUtc");

                    b.Property<string>("Description");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDateOnUtc");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("MyShop.Data.Entities.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("City");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedDateOnUtc");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDateOnUtc");

                    b.Property<string>("District");

                    b.Property<int>("Gender");

                    b.Property<string>("IdentityId")
                        .IsRequired();

                    b.Property<string>("IdentityId1");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDateOnUtc");

                    b.Property<string>("ShippingAddress");

                    b.Property<string>("ShippingCity");

                    b.Property<string>("ShippingDistrict");

                    b.Property<string>("ShippingWard");

                    b.Property<string>("Ward");

                    b.HasKey("Id");

                    b.HasIndex("IdentityId1");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MyShop.Data.Entities.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedDateOnUtc");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDateOnUtc");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDateOnUtc");

                    b.Property<string>("Note");

                    b.Property<string>("Number");

                    b.Property<string>("Status");

                    b.HasKey("Id");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MyShop.Data.Entities.OrderDetail", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<int>("Quantity");

                    b.HasKey("Id");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("MyShop.Data.Entities.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<float>("AverageRating");

                    b.Property<string>("CreatedBy");

                    b.Property<DateTime?>("CreatedDateOnUtc");

                    b.Property<DateTime>("DateSaleFromUtc");

                    b.Property<DateTime>("DateSaleToUtc");

                    b.Property<string>("DeletedBy");

                    b.Property<DateTime?>("DeletedDateOnUtc");

                    b.Property<string>("Description");

                    b.Property<string>("ImageUrl");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("ModifiedBy");

                    b.Property<DateTime?>("ModifiedDateOnUtc");

                    b.Property<string>("Name");

                    b.Property<bool>("OnSale");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<float>("RatingCount");

                    b.Property<decimal>("SalePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Sku");

                    b.Property<string>("Status")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue("Pushlish");

                    b.Property<int>("StockQuantity");

                    b.Property<int>("TotalSale");

                    b.Property<string>("Weight");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MyShop.Data.Entities.ProductCategory", b =>
                {
                    b.Property<int>("CategoryId");

                    b.Property<int>("ProductId");

                    b.HasKey("CategoryId", "ProductId");

                    b.HasIndex("ProductId");

                    b.ToTable("ProductCategory");
                });

            modelBuilder.Entity("MyShop.Data.Entities.Wallet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<string>("CustomerId");

                    b.Property<Guid>("Guid");

                    b.Property<string>("Label");

                    b.HasKey("Id");

                    b.HasAlternateKey("Guid")
                        .HasName("Unique_Guid");

                    b.HasIndex("CustomerId")
                        .IsUnique()
                        .HasFilter("[CustomerId] IS NOT NULL");

                    b.ToTable("Wallet");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyShop.Data.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyShop.Data.Entities.Customer", b =>
                {
                    b.HasOne("MyShop.Data.Entities.AppUser", "Identity")
                        .WithMany()
                        .HasForeignKey("IdentityId1");
                });

            modelBuilder.Entity("MyShop.Data.Entities.OrderDetail", b =>
                {
                    b.HasOne("MyShop.Data.Entities.Order", "Order")
                        .WithOne("OrderDetail")
                        .HasForeignKey("MyShop.Data.Entities.OrderDetail", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyShop.Data.Entities.ProductCategory", b =>
                {
                    b.HasOne("MyShop.Data.Entities.Category", "Category")
                        .WithMany("ProductCategories")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("MyShop.Data.Entities.Product", "Product")
                        .WithMany("ProductCategories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("MyShop.Data.Entities.Wallet", b =>
                {
                    b.HasOne("MyShop.Data.Entities.Customer", "Customer")
                        .WithOne("Wallet")
                        .HasForeignKey("MyShop.Data.Entities.Wallet", "CustomerId")
                        .HasPrincipalKey("MyShop.Data.Entities.Customer", "IdentityId");
                });
#pragma warning restore 612, 618
        }
    }
}
