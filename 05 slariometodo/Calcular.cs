﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace slariometodo
{
    internal class Calcular
    {
        public double Sueldo(int h, double pph)
        {
            if (h <= 40)
            {
                return h * pph;

            }
            if (h > 40 && h <= 52)
            {

                return (40 * pph) + ((h - 40) * pph * 2);
            }
            else
                return (40 * pph) + (12 * pph * 2) + ((h - 52) * pph * 3);


        }
    }
}
