using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFirstShop.Table;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstShop.DataBase.CreateModel
{
    public class DepositShopModel : IEntityTypeConfiguration<DepositShop>
    {
        public void Configure(EntityTypeBuilder<DepositShop> builder)
        {
            builder.HasKey(ds => ds.Id);
            builder.HasOne(ds => ds.shop)
                   .WithMany(s => s.depositShopList);
            builder.HasOne(ds => ds.deposit)
                   .WithMany(d => d.depositShopList); 
        }
    }
}
