using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string PaymentType1 { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
    }
}
