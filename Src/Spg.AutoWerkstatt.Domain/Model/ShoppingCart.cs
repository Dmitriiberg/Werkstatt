using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public enum States { ACTIVE = 0, INPAYMENT, SENT }
    public class ShoppingCart
    {
        public long ShoppingCartId { get; set; }

        public States State { get; set; }

        public long UserId { get; set; }
        public User User { get; set; }

        public long PaymentId { get; set; }
        public IReadOnlyList<Payment> Payments { get; set; }

    }
}
