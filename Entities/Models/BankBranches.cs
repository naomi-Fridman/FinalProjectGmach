using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class BankBranches
    {
        public BankBranches()
        {
            DirectDebit = new HashSet<DirectDebit>();
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public int? BranchNumber { get; set; }
        public int? BankCode { get; set; }
        public string BranchName { get; set; }

        public virtual ICollection<DirectDebit> DirectDebit { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
