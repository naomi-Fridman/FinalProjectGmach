using Entities.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BL
{
    public interface IpaymentTypeBl
    {
        Task<int> getPaymentIdByTypeName(string typeName);

    }
}