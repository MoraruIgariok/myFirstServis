using Microsoft.EntityFrameworkCore;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.DataBase.CreateModel
{
    public class ShopModel : IEntityTypeConfiguration<Shop>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Shop> builder)
        {
            builder.HasKey(s => s.Id);  
            builder.HasMany(s=>s.depositShopList)
                   .WithOne(ds=>ds.shop)
                   .HasForeignKey(s=>s.ShopId);    
        }
    }
}
