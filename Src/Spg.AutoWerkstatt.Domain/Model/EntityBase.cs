﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class EntityBase
    {
        public int Id { get; private set; }
        public DateTime Created { get; set; }
        public DateTime? LastChangeDate { get; set; }
    }
}
