using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class DTO_UserParams
    {
        public int ?Id { get; set; }

        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Address { get; set; }
        public string? City { get; set; }
        public int? TelephoneNumber1 { get; set; }
        public int? TelephoneNumber2 { get; set; }
        public string? Email { get; set; }
        public int? IdentityNumber { get; set; }

    }
}
