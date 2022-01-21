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
        public string Location { get; set; }

        public int Phone { get; set; }
        public string Email { get; set; }

        public Address Address { get; set; }
       
        protected List<Category> _categories = new();
        public virtual IReadOnlyList<Category> Categories => _categories;


        protected List<Leistungen> _leistungens = new();

        public Werkstatt(long werkstattId, string name, string location, int phone, string email, Address address)
        {
            WerkstattId = werkstattId;
            Name = name;
            Location = location;
            Phone = phone;
            Email = email;
            Address = address;
        }

        //public virtual IReadOnlyList<Leistungen> Leistungens => _leistungens;

    }
}
