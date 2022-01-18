using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class User
    {
        public long UserId { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Stadt { get; set; }

        public string Adresse { get; set; }
        public int Plz { get; set; }

        public int Tel { get; set; }
        public string Email { get; set; }

        public IReadOnlyList<ShoppingCart> ShoppingCarts { get; set; }
    }
}
