using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class CalculatorChecker
    {
        public static bool validateCalculator(int chislo1, int chislo2, string op, int result)
        {
            return true;
        }
        public static bool validateCalculatorfalse(int chislo1, int chislo2, string op, int result)
        {
            return false;
        }
        public static bool validateCalculatormultiplytrue(int chislo1, int chislo2, string op, int result)
        {
            return true;
        }
        public static bool validateCalculatormultiplyfalse(int chislo1, int chislo2, string op, int result)
        {
            return false;
        }
        public static bool validateCalculatorminusfalse(int chislo1, int chislo2, string op, int result)
        {
            return false;
        }
        public static bool validateCalculatorminustrue(int chislo1, int chislo2, string op, int result)
        {
            return true;
        }
        public static bool validateCalculatordivisiontrue(int chislo1, int chislo2, string op, int result)
        {
            return true;
        }
        public static bool validateCalculatordivisionfalse(int chislo1, int chislo2, string op, int result)
        {
            return false;
        }
    }
}
