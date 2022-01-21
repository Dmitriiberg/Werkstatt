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
            builder.HasKey(x => x.LeistungenId);
            builder.Property(x => x.LeistungenId).UseIdentityColumn();

            builder
                .HasOne<Category>()
                .WithMany(y => y.Leistungens)
                .HasForeignKey(y => y.LeistungenId);
        }
    }
}
