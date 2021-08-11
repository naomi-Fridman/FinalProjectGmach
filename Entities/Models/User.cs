using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class User
    {
        public User()
        {
            Deposits = new HashSet<Deposits>();
            DirectDebit = new HashSet<DirectDebit>();
            Guarnty = new HashSet<Guarnty>();
            Loan = new HashSet<Loan>();
            Payment = new HashSet<Payment>();
        }

        public int Id { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public long TelephoneNumber1 { get; set; }
        public long TelephoneNumber2 { get; set; }
        public string Email { get; set; }
        public string Comments { get; set; }
        public int IdentityNumber { get; set; }

        public virtual ICollection<Deposits> Deposits { get; set; }
        public virtual ICollection<DirectDebit> DirectDebit { get; set; }
        public virtual ICollection<Guarnty> Guarnty { get; set; }
        public virtual ICollection<Loan> Loan { get; set; }
        public virtual ICollection<Payment> Payment { get; set; }
    }
}
