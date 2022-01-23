using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public enum PaymentStates { Reserved = 0, InPayment, Payed, Rejected }

    public class Payment : EntityBase
    {
        protected Payment() { }
        public Payment(PaymentStates paymentStates, decimal price)
        {
            PaymentStates = paymentStates;
            Price = price;
        }

        public PaymentStates PaymentStates { get; set; }

        public decimal Price { get; set; }

        public long ShoppingCartId { get; set; }
        public ShoppingCart ShoppingCart { get; private set; } = null!;

    }
}
