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
            double res;
            res = a % b;
            if (double.IsInfinity(res))
                throw new OverflowException();
            return res;
           
            
        }
    
    }
}
