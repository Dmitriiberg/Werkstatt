using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class Price : EntityBase
    {
        protected Price() { }
        public Price( decimal netto, decimal tax, Leistungen leistungen)
        {
            Netto = netto;
            Tax = tax;
            Leistungen = leistungen;
        }

        public decimal Netto { get; set; }
        public decimal Tax { get; set; }
        public decimal Brutto => Netto * 1.8M;

        public long LeistungId { get; set; }
        public virtual Leistungen Leistungen { get; private set; } = null!;
    }
}
