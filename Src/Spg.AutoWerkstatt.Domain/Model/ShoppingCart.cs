using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public enum States { ACTIVE = 0, INPAYMENT, SENT }

    public class ShoppingCart : EntityBase
    {
        public ShoppingCart(States state, long userId, User user)
        {
            State = state;
            UserId = userId;
            User = user;
        }

        public States State { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        private List<Payment> _paymentList = new();
        public IReadOnlyList<Payment> Payments => _paymentList;
    }
}
