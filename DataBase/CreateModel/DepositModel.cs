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
    public class DepositModel : IEntityTypeConfiguration<Deposit>
    {
        public void Configure(EntityTypeBuilder<Deposit> builder)
        {
            builder.HasKey(d => d.Id);  

            builder.HasMany(d => d.depositShopList)
                   .WithOne(ds => ds.deposit)
                   .HasForeignKey(ds => ds.DepositId);
            builder.HasMany(d => d.depositPorductList)
                .WithOne(dp => dp.currentDeposit)
                .HasForeignKey(dp => dp.DepositId);
        }
    }
}
