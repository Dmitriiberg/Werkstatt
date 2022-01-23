using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public class User : EntityBase
    {
        protected User() { }

        public User(GenderTypes gender, string firstName, string lastName, int tel, string email, Address address)
        {
            Gender = gender;
            FirstName = firstName;
            LastName = lastName;
            Phone = tel;
            Email = email;
            Address = address;
        }

        public enum GenderTypes { FEMALE = 0, MALE = 1 };

        public GenderTypes Gender { get; set; }
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public int Phone { get; set; }
        public string Email { get; set; }

        public Address Address { get; set; }

        protected List<ShoppingCart> _shoppingCarts = new();

        public virtual IReadOnlyList<ShoppingCart> ShoppingCarts => _shoppingCarts; 
    }
}
