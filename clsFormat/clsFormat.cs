﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankSystem.GlobalClasses
{
    public class clsFormat
    {
public static string DateToString(DateTime dt)
        {
            return dt.ToString("dd/MMM/yyyy");
        }
    }
}
