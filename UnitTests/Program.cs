using System;

namespace UnitTests
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите число для факториала> ");
            var number = int.Parse(Console.ReadLine());
            Console.WriteLine($"Результат обычной функции:\t{FactorialSolver.Factorial(number)}");
            Console.WriteLine($"Результат рекурсивной функции:\t{FactorialSolver.FactorialRecursion(number)}");
            Console.WriteLine($"Результат while функции:\t{FactorialSolver.FactorialWhileLoop(number)}");
        }

    }
}