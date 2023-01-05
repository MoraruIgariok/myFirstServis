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
    public class DepositProductModel : IEntityTypeConfiguration<DepositProduct>
    {
        public void Configure(EntityTypeBuilder<DepositProduct> builder)
        {
            builder.HasKey(dp => dp.Id);
            builder.HasOne(dp => dp.currentProduct)
                .WithMany(p => p.depositPorductList);
            builder.HasOne(dp => dp.currentDeposit)
                .WithMany(d => d.depositPorductList);
        }
    }
}
