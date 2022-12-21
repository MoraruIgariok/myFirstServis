using Microsoft.EntityFrameworkCore;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyFirstShop.DataBase;
using Microsoft.Extensions.Options;


namespace MyFirstShop.DataBase
{
    public class MyFirstShopContext : DbContext
    {
        public MyFirstShopContext()
        {
            Database.EnsureDeleted();

            Database.EnsureCreated();
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
        public DbSet<Basket> Baskets { get; set; }

        //Connecting to data base.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1423;User ID=sa;Password=MoldovaN92#!;Database=MyFirstDBShop;TrustServerCertificate=True;");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        ///schem for One -more
        ///
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ///client
            modelBuilder.Entity<Client>()
                .HasKey(c => c.ClientId);
            modelBuilder.Entity<Client>()
                .Property(c => new { c.Last_Name, c.First_Name, c.Phone_Number, c.EmailAdress })
                .HasMaxLength(50);
            ///product
            modelBuilder.Entity<Product>()
               .HasKey(p => p.ProductId);
            modelBuilder.Entity<Product>()
               .Property(p => new { p.Name, p.Descripion })
               .HasMaxLength(100);
            modelBuilder.Entity<Product>()
               .Property(p => new { p.Price, p.Quantity })
               .HasPrecision(10, 2);
        ///Basket
            modelBuilder.Entity<Basket>()
                .HasKey(b => b.BasketId);
            modelBuilder.Entity<Basket>()
                .Property(b => b.CodNameBaket)
                .HasMaxLength(20);
            modelBuilder.Entity<Basket>()
                .HasOne(b=>b.CurrentClient)
                .WithOne(c=>c.CurrentBasket)
                .HasForeignKey<Basket>(c=>c.ClientId);
            ///BasketProduct
            modelBuilder.Entity<BasketProduct>()
                .HasKey(bp => bp.Id);
            modelBuilder.Entity<BasketProduct>()
                .Property(bp => bp.Count)
                .HasPrecision(10, 2);
            modelBuilder.Entity<BasketProduct>()
                .HasMany(bp => bp.products)
                .WithMany(p => p.CurrentBasketProduct);
            modelBuilder.Entity<BasketProduct>()
                .HasMany(bp => bp.baskets)
                .WithMany(b => b.CurrentBasketProduct);
                
                

                   
             
                




        }
    }
}
