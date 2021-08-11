using System;
using System.Collections.Generic;

namespace Entities.Models
{
    public partial class Payment
    {
        public int Id { get; set; }
        public int TypeId { get; set; }
        public int UserId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int CollectionSum { get; set; }
        public int CurrencyId { get; set; }
        public int? ExchangeRate { get; set; }
        public int? Fee { get; set; }
        public int? FeeDescriptionId { get; set; }
        public string Comments { get; set; }
        public int PaymentMethodId { get; set; }
        public int? BankId { get; set; }
        public int? BranchNumberId { get; set; }
        public int? AccountNumber { get; set; }
        public int? DirectDebitId { get; set; }
        public int? Reference { get; set; }
        public DateTime? InputDate { get; set; }
        public string HebrewPaymentDate { get; set; }
        public short? Deleted { get; set; }
        public int? CreditCardId { get; set; }

        public virtual Banks Bank { get; set; }
        public virtual BankBranches BranchNumber { get; set; }
        public virtual CreditCard CreditCard { get; set; }
        public virtual CurrencyType Currency { get; set; }
        public virtual DirectDebit DirectDebit { get; set; }
        public virtual FeeDescription FeeDescription { get; set; }
        public virtual PaymentMethod PaymentMethod { get; set; }
        public virtual PaymentType Type { get; set; }
        public virtual User User { get; set; }
    }
}
