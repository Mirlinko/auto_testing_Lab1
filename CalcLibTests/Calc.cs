using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcLib
{
    public class Calc
    {
        public static double Mod(double a, double b)
        {
            double r;
            r = a % b;
            if (double.IsInfinity(r))
                throw new OverflowException();
            return r;
           
            
        }
   
    }
}
