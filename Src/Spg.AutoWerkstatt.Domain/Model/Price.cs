﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class Price
    {
        public long Id { get; set; }

        public decimal Netto { get; set; }
        public decimal Tax { get; set; }
        public decimal Brutto { get { return Netto * 1.8M ; } }

        public long LeistungId { get; set; }

        public virtual Leistungen Leistungen { get; set; }
    }
}