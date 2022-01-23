using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class Category : EntityBase
    {
        protected Category() { }
        public Category(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public int PriceMultiplay { get; set; }

        public virtual IList<Leistungen> Leistungens { get; set; }

        protected List<Werkstatt> _werkstatt = new();
        public virtual IReadOnlyList<Werkstatt> Werkstatt => _werkstatt;
    }
}
