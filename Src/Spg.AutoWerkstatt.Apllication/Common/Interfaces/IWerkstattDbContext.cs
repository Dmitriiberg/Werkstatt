using Microsoft.EntityFrameworkCore;
using Spg.AutoWerkstatt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Apllication.Common.Interfaces
{
    public interface IWerkstattDbContext
    {
        DbSet<User> User { get; set; }

        DbSet<Category> Category {get; set;}

    }
}
