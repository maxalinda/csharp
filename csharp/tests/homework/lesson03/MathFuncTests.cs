using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.tests
{

    [TestFixture]
    class MathFuncTests
    {
        MathFunc math = new MathFunc();
        [Test]
        public void MultiplyTest()
        {
            int a = 2;
            int b = 2;
            int expected = 4;
            Assert.AreEqual(expected, math.Multiply(a, b));
        }
        [Test]
        public void MultiplyTest2()
        {
            int a = 0;
            int b = 3;
            int expected = 4;
            Assert.AreNotEqual(expected, math.Multiply(a, b));
        }
        [Test]
        public void AdditionTest()
        {
            int a = 2;
            int b = 3;
            int expected = 5;
            Assert.AreEqual(expected, math.Addition(a, b));
        }

        [Test]
        public void SubstractionTest()
        {
            int a = 6;
            int b = 4;
            int expected = 2;
            Assert.AreEqual(expected, math.Substraction(a, b));
        }

        [Test]
        public void DivisionTest()
        {
            int a = 8;
            int b = 2;
            int expected = 4;
            Assert.AreEqual(expected, math.Division(a, b));
        }

    }
}
