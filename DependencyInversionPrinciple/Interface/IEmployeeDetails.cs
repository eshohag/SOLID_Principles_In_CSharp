﻿using DependencyInversionPrinciple.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependencyInversionPrinciple.Interface
{
    interface IEmployeeDetails
    {
        List<Employee> Details();
    }
}
