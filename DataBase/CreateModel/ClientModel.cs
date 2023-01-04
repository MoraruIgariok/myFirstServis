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
    internal class ClientModel : IEntityTypeConfiguration<Client>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Client> builder)
        {
            builder.HasKey(c => c.ClientId);
            
            builder.HasOne(c => c.CurrentBasket)
                   .WithOne(b => b.CurrentClient)
                   .HasForeignKey<Basket>(b => b.ClientId);
        }
    }
}
