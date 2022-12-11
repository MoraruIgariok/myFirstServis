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
       public MyFirstShopContext() : base() 
        { 

        }       

        public DbSet<Product> Products { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<BasketProduct> BasketProducts { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=127.0.0.1,1423;User ID=sa;Password=MoldovaN92#!;Database=MyFirstDBShop;TrustServerCertificate=True;");

    }
}
