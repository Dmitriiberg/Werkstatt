using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Spg.AutoWerkstatt.Domain.Model;

namespace Spg.AutoWerkstatt.DbEf.Configurations
{
    class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).UseIdentityColumn();

            builder
                .HasMany<Leistungen>(x => x.Leistungens)
                .WithOne(y => y.Category)
                .HasForeignKey(y => y.CategoryId);
        }
    }
}
