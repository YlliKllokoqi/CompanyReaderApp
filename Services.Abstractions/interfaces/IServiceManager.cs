﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Abstractions.interfaces
{
    public interface IServiceManager
    {
        ICompanyService companyService { get; }
    }
}