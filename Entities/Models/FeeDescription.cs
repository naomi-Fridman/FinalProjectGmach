using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class FeeDescription
    {
        public FeeDescription()
        {
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Payment> Payment { get; set; }
    }
}
