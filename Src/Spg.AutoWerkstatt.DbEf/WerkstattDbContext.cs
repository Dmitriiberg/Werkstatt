using Microsoft.EntityFrameworkCore;
using Spg.AutoWerkstatt.Apllication.Common.Interfaces;
using Spg.AutoWerkstatt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.DbEf
{
    public class WerkstattDbContext : DbContext, IWerkstattContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Category> Category { get; set; }
        public DbSet<Leistungen> Leistungens { get; set; }

        public void Seed()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(WerkstattDbContext).Assembly);

            Seed();
        }
    }
}
