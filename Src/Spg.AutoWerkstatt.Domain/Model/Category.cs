using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class Category
    {
        public Category(string name, Werkstatt werkstatt)
        {
            Name = name;
            WerkstattNavigation = werkstatt;

        }
        public long CategoryId { get; set; }

        public string Name { get; set; }

        public int PriceMultiplay { get; set; }

        public virtual Werkstatt WerkstattNavigation { get; private set; }

        protected List<Leistungen> _leistungens = new();
        public virtual IReadOnlyList<Leistungen> Leistungens => _leistungens;
    }
}
