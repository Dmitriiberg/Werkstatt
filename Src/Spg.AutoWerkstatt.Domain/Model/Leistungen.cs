using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{

    public class Leistungen : EntityBase
    {
        protected Leistungen() { }
        public Leistungen(string name, long categoryId, Category category, long werkstattId, Werkstatt werkstatt)
        {
            Name = name;
            CategoryId = categoryId;
            Category = category;
            WerkstattId = werkstattId;
            Werkstatt = werkstatt;
        }

        public string Name { get; set; }

        public long CategoryId { get; set; }
        public virtual Category Category { get; set; }

        public long WerkstattId { get; set; }
        public virtual Werkstatt Werkstatt { get; set; }


        protected List<Price> _prices = new();

        public virtual IReadOnlyList<Price> Prices => _prices;




        //public  void AddPrice(Price price)
        //{
        //    if (price == default)
        //        throw new ArgumentNullException("Price ist null");
        //    {
        //        _prices.Add(price);
        //    }
        //}

        //public void AddPrice(List<Price> price)
        //{
        //    _prices.AddRange(price);

        //}
    }
}
