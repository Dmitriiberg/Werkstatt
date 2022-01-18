using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class Category
    {
        public long CategoryId { get; set; }

        public string Name { get; set; }

        public int PriceMultiplay { get; set; }

        public virtual IReadOnlyList<Leistungen> Leistungens { get; set; }
    }
}
