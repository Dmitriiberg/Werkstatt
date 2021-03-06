using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.AutoWerkstatt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.DbEf.Configurations
{
    public class ShoppingCartConfiguration : IEntityTypeConfiguration<ShoppingCart>
    {
        public void Configure(EntityTypeBuilder<ShoppingCart> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder
                .HasOne<User>(u => u.User)
                .WithMany(s => s.ShoppingCarts)
                .HasForeignKey(x => x.UserId);

            builder
                .HasMany<Payment>(x => x.Payments)
                .WithOne(x => x.ShoppingCart)
                .HasForeignKey(x => x.ShoppingCartId);
        }
    }
}
