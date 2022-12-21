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
    public class BasketProductModel : IEntityTypeConfiguration<BasketProduct>
    {
        public void Configure(EntityTypeBuilder<BasketProduct> builder)
        {
            builder.HasKey(bp => bp.Id);
            builder.Property(bp => bp.Count)
                   .HasPrecision(10, 2);
            builder.HasMany(bp => bp.products)
                   .WithMany(p => p.CurrentBasketProduct);
            builder.HasMany(bp => bp.baskets)
                   .WithMany(b => b.CurrentBasketProduct);
            
        }
    }
}
