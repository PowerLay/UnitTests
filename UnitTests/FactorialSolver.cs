using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class FactorialSolver
    {
        public static int Factorial(int number)
        {
            var fact = 1;
            for (var i = 1; i <= number; i++) fact = fact * i;
            return fact;
        }
        public static int FactorialRecursion(int number)
        {
            if (number == 1)
                return 1;
            else
                return number * FactorialRecursion(number - 1);
        }
        public static int FactorialWhileLoop(int number)
        {
            int result = 1;
            while (number != 1)
            {
                result *= number;
                number -= 1;
            }
            return result;
        }
    }
}
