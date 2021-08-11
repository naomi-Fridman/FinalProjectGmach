using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DL
{
    public interface IpaymentTypeDl
    {
        Task<int> getPaymentIdByTypeName(string typeName);
    }
}