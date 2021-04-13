using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace UnitTests.Tests
{
    public class UnitTestsFactorialRecursion
    {

        [Fact]
        public void Factorial1()
        {
            int number = 1;
            int expect = 1;

            int res = FactorialSolver.FactorialRecursion(number);

            Assert.Equal(expect, res);
        }

        [Fact]
        public void Factorial3()
        {
            int number = 3;
            int expect = 6;

            int res = FactorialSolver.FactorialRecursion(number);

            Assert.Equal(expect, res);
        }

        [Fact]
        public void Factorial5()
        {
            int number = 5;
            int expect = 120;

            int res = FactorialSolver.FactorialRecursion(number);

            Assert.Equal(expect, res);
        }

        [Fact]
        public void Factorial8()
        {
            int number = 8;
            int expect = 40320;

            int res = FactorialSolver.FactorialRecursion(number);

            Assert.Equal(expect, res);
        }

        [Fact]
        public void Factorial9()
        {
            int number = 9;
            int expect = 362880;

            int res = FactorialSolver.FactorialRecursion(number);

            Assert.Equal(expect, res);
        }
    }
}
