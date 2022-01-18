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
            builder.HasKey(x => x.ShoppingCartId);
            builder.Property(x => x.ShoppingCartId).UseIdentityColumn();

            builder
                .HasOne<User>(u => u.User)
                .WithMany(s => s.ShoppingCarts)
                .HasForeignKey(x => x.UserId);

        }
    }
}
