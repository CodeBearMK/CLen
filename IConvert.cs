﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface2
{
    internal interface IConvert
    {
        double Mult { get; set; }
        void Convert(double l);
    }
}
