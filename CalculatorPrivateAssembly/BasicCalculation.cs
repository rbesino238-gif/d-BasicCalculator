using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorPrivateAssembly
{
    public class BasicCalculation
    {       
        // Addition
        public static float Add(float a, float b)
        {
            return a + b;
        }

        //Substactiom
        public static float Substact(float a, float b)
        {
            return a - b;
        }

        //Multiplication
        public static float Multiply(float a, float b)
        {
            return a * b;
        }

        //Division
        public static float Divide(float a, float b)
        {
            return b != 0 ? a / b : 0;
        }
    }
}
