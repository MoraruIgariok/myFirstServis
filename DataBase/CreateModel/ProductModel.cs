using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.DataBase.CreateModel
{
    public class ProductModel : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(p => p.ProductId);
            
            
            //////////////////////////////////////////////////////
            builder.HasMany(p => p.CurrentBasketProduct)
                   .WithOne(bp=>bp.products)
                   .HasForeignKey(bp => bp.ProductId);
            
                
            
               
                  
        }
    }
}
