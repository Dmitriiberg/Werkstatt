using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Spg.AutoWerkstatt.Domain.Model
{
    public enum PaymentStates { Reserved = 0, InPayment, Payed, Rejected }

    public class Payment
    {
        public long PaymentId { get; set; }

        public PaymentStates PaymentStates { get; set; }

        public decimal Price { get; set; }
    }
}
