using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Arthmetic
    {
        public int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public int Sub(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        public int ConvertTemp(int temp, string unit)
        {
            int result = 0;
            if(unit == "C")
            {
                result = (temp - 32) * 5 / 9;
            }
            else if (unit == "F")
            {
                result = (temp * 9 / 5) + 32;
            }
            return result;
        }
    }
}
