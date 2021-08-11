using DL;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class paymentTypeBl : IpaymentTypeBl
    {
        IpaymentTypeDl ipaymentTypeDl;
        public paymentTypeBl(IpaymentTypeDl _ipaymentTypeDl)
        {
            ipaymentTypeDl = _ipaymentTypeDl;
        }
        public async Task<int> getPaymentIdByTypeName(string typeName)
        {
            return await ipaymentTypeDl.getPaymentIdByTypeName(typeName);
        }

    }
}
