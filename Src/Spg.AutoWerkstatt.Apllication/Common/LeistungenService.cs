using Microsoft.EntityFrameworkCore;
using Spg.AutoWerkstatt.Apllication.Common.Interfaces;
using Spg.AutoWerkstatt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Apllication.Common
{
    public class LeistungenService : ILeistungenService
    {
        // DI !!!
        private readonly IWerkstattContext _werkstattDb;

        public LeistungenService(IWerkstattContext werkstattDb)
        {
            _werkstattDb = werkstattDb;
        }

        public async Task<IList<Leistungen>> GetAll(long categoryId)
        {
            var result = await _werkstattDb.Leistungens.Where(x => x.CategoryId == categoryId).ToListAsync();
            return result;
        }
    }
}
