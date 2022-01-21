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
            builder.HasKey(x => x.CategoryId);
            builder.Property(x => x.CategoryId).UseIdentityColumn();

            builder
                .HasMany<Leistungen>()
                .WithOne(y => y.Category)
                .HasForeignKey(y => y.CategoryId);
        }
    }
}
