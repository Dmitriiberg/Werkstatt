using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class Werkstatt
    {
        public long WerkstattId { get; set; }

        public string Name { get; set; }
        public string Stadt { get; set; }

        public string Adresse { get; set; }
        public int  Plz { get; set; }
        

        public int Tel { get; set; }
        public string Email { get; set; }


        protected List<Leistungen> _leistungens = new();
        public virtual IReadOnlyList<Leistungen> Leistungens => _leistungens;

    }
}
