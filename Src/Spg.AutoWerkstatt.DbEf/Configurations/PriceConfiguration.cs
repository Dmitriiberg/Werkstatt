using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Spg.AutoWerkstatt.Domain.Model;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Spg.AutoWerkstatt.DbEf.Configurations
{
    public class PriceConfiguration : IEntityTypeConfiguration<Price>
    {
        public void Configure(EntityTypeBuilder<Price> builder)
        {
            builder.HasKey(x => x.PriceId);
            builder.Property(x => x.PriceId).UseIdentityColumn();

            builder
                .HasMany<Leistungen>()
                .WithMany(y => y.Prices)
                .UsingEntity(j => j.ToTable("LeistungenPrice"));    //WTF???

        }
    }
}
