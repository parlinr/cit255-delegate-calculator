using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateCalculator
{
    public static class MyMath
    {
        public enum Operation
        {
            NONE,
            ADD
        }
        
        public static double Add(double number1, double number2)
        {
            return number1 + number2;
        }
    }
}
