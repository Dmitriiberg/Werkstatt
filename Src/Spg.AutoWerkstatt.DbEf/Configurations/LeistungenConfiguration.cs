using Spg.AutoWerkstatt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Spg.AutoWerkstatt.DbEf.Configurations
{
    public class LeistungenConfiguration : IEntityTypeConfiguration<Leistungen>
    {
        public void Configure(EntityTypeBuilder<Leistungen> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder
                .HasOne<Category>(x => x.Category)
                .WithMany(x => x.Leistungens)
                .HasForeignKey(x => x.CategoryId);

            builder
                .HasMany<Price>(x => x.Prices)
                .WithOne(x => x.Leistungen)
                .HasForeignKey(x => x.LeistungId);
        }
    }
}
