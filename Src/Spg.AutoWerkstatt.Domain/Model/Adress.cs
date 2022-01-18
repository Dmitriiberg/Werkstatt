using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class Adress
    {
        public long AdressId { get; set; }
        public  string City { get; set; }
        public string Street { get; set; }
        public int PostCode { get; set; }

        public User User { get; set; }

        public long UserId { get; set; }
        public Werkstatt Werkstatt { get; set; }
        public long WerkstattId { get; set; }




    }
}
