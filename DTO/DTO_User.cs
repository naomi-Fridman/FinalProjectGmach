using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_User
    {
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
        public List<DTO_Loan> Loan { get; set; }
    }
}
