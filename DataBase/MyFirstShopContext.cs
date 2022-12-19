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

        //Connecting to data base.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { 
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1423;User ID=sa;Password=MoldovaN92#!;Database=MyFirstDBShop;TrustServerCertificate=True;");
            optionsBuilder.LogTo(Console.WriteLine);
        }

        ///schem for One -more
        ///
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BasketProduct>()
               .HasOne<Client>(b => b.CurrentClient)
               .WithMany(c => c.CurremtBasketProduct)
               .HasForeignKey(b => b.ClientId);

            modelBuilder.Entity<BasketProduct>()
               .HasOne<Product>(b => b.CurrentProduct)
               .WithMany(c => c.CurrentBasketProduct)
               .HasForeignKey(b => b.ProductId);

        }
    }
}
