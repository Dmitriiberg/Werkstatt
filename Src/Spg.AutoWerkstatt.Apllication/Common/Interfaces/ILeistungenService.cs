using Spg.AutoWerkstatt.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Apllication.Common.Interfaces
{
    public interface ILeistungenService
    {
        Task<IList<Leistungen>> GetAll(long categoryId);
    }
}
