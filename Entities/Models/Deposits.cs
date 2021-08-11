using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Deposits
    {
        public int Id { get; set; }
        public int Sum { get; set; }
        public int CurrencyId { get; set; }
        public DateTime? ReturnDate { get; set; }
        public string Comment { get; set; }
        public bool Status { get; set; }
        public string HebrewDepositeDate { get; set; }
        public string HebrewDepositeReturnDate { get; set; }
        public int? DirectDebitId { get; set; }
        public int? PaymentsNumber { get; set; }
        public int? CreditCardId { get; set; }
        public int UserId { get; set; }
        public DateTime DepositeDate { get; set; }

        public virtual CreditCard CreditCard { get; set; }
        public virtual CurrencyType Currency { get; set; }
        public virtual DirectDebit DirectDebit { get; set; }
        public virtual User User { get; set; }
    }
}
