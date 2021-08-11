using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DL
{
    public class paymentTypeDl : IpaymentTypeDl
    {
        gmach277Context gmachContext;
        public paymentTypeDl(gmach277Context _gmachContext)
        {
            gmachContext = _gmachContext;
        }
        public async Task<int> getPaymentIdByTypeName(string typeName)
        {
            PaymentType p = await gmachContext.PaymentType.Where(x => x.PaymentType1 == typeName).FirstOrDefaultAsync();
            return p.Id;
        }
    }
}
