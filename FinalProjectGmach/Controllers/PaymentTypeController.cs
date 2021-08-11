using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL;
using Entities.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FinalProjectGmach.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentTypeController : ControllerBase
    {
        IpaymentTypeBl paymentTypeBl;
        public PaymentTypeController(IpaymentTypeBl _PaymentTypeBl)
        {
            paymentTypeBl = _PaymentTypeBl;
        }

        [HttpGet("{typeName}")]
        public async Task<int> getPaymentIdByTypeName(string typeName)
        {
            return await paymentTypeBl.getPaymentIdByTypeName(typeName);
        }
        

    }
}