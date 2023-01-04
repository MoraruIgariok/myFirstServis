using Microsoft.EntityFrameworkCore;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstShop.DataBase;
using Microsoft.Extensions.Options;
using MyFirstShop.DataBase.CreateModel;

namespace MyFirstShop.DataBase
{
    public class MyFirstShopContext : DbContext
    {
        public MyFirstShopContext()
        {
            Database.EnsureDeleted();

           // Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
        public DbSet<Basket> Baskets { get; set; }
        public DbSet<Shop> Shops { get; set; }
        public DbSet<Deposit> Deposites { get; set; }   
        public DbSet<DepositShop> DepositShops { get; set; }


        //Connecting to data base.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1423;User ID=sa;Password=MoldovaN92#!;Database=MyFirstDBShop;TrustServerCertificate=True;");
            //optionsBuilder.LogTo(Console.WriteLine);
        }

        ///schem for One -more
        ///
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///client
            modelBuilder.ApplyConfiguration(new ClientModel());           
            ///product
            modelBuilder.ApplyConfiguration(new ProductModel());
            ///Basket
            modelBuilder.ApplyConfiguration(new BasketModel());
            ///BasketProduct
            modelBuilder.ApplyConfiguration(new BasketProductModel());
            ///SHOP 
            modelBuilder.ApplyConfiguration(new ShopModel());
            ///Deposit
            modelBuilder.ApplyConfiguration(new DepositModel());
            ///DEpositShop
            modelBuilder.ApplyConfiguration(new DepositShopModel());
        }
    }
}
