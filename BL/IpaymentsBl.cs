﻿

using DTO;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IpaymentsBl
    {
        Task<List<Payment>> getAllPaymentsForLoan(int userId, int paymentId);
        Task<List<DTO_User>> getAllPaymentsThatWerentPadeByDate(DateTime date);
        Task<List<Payment>> getAllPayments(DTO_PaymentParams dTO_PaymentParams);
        Task updatePayment(Payment updatedPayment);
        Task<int> postPayment(Payment payment);
        Task<List<Payment>> getAllPaymentsForLoanByUserIdAndLoanDate(int userId, DateTime loanDate);
    }
}
