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
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder
                .HasOne<Leistungen>(x => x.Leistungen)
                .WithMany(x => x.Prices)
                .HasForeignKey(x => x.LeistungId);
        }
    }
}
