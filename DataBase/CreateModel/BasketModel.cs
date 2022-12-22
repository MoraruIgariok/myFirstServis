using Microsoft.EntityFrameworkCore;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.DataBase.CreateModel
{
    public class BasketModel:IEntityTypeConfiguration<Basket>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Basket> builder)
        {

            builder.HasKey(b => b.BasketId);
            builder.Property(b => b.CodNameBaket)
                   .HasMaxLength(20);
            builder.HasMany(b => b.CurrentBasketProduct)
                   .WithOne(bp => bp.baskets)
                   .HasForeignKey(bp => bp.BasketId);
        }
    }
}
