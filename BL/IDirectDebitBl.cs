﻿using Entities.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public interface IDirectDebitBl
    {
        Task post(DirectDebit directDebit);
    }
}
