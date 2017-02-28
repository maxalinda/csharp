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
        MathFunc math;

        [OneTimeSetUp]
        public void OneTimeSetUp() {
             math = new MathFunc();
        }
        static object[] multiplyData = {
            new object[] {3, 4, 12, true },
            new object[] {12, 4, 48, true },
            new object[] {12, 5, 90, false }
        };

        static object[] multiplyData2 = {
            new object[] {3, 54, 12 },
            new object[] {12, 41, 48 },
            new object[] {1, 5, 50 }
        };
        static object[] additionData  = {
            new object[] {3, 2, 5 },
            new object[] {12, 12, 24 },
            new object[] {1, 5, 6 }
        };
        static object[] substractionData = {
            new object[] {8, 2, 6 },
            new object[] {12, 12, 0 },
            new object[] {1, 5, -4 }
        };
        static object[] divisionData = {
            new object[] {6, 2, 3 },
            new object[] {12, 12, 24 },
            new object[] {1, 5, 6 }
        };


        [Test, TestCaseSource("multiplyData")]
        public void MultiplyTest(int a, int b, int expected, bool result)
        {
           Assert.AreEqual(result, expected == math.Multiply(a, b));
           
        }

        [Test, TestCaseSource("multiplyData2")]
        public void MultiplyTest2(int a, int b, int expected)
        {           
            Assert.AreNotEqual(expected, math.Multiply(a, b));
        }

        [Test, TestCaseSource("additionData")]
        public void AdditionTest(int a, int b, int expected)
        {
            Assert.AreEqual(expected, math.Addition(a, b));
        }

        [Test, TestCaseSource("substractionData")]
        public void SubstractionTest(int a, int b, int expected)
        {
          Assert.AreEqual(expected, math.Substraction(a, b));
        }

        [Test, TestCaseSource("divisionData")]
        [Ignore("Shit Happens. Not ready")]       
        public void DivisionTest(int a, int b, int expected)
        {
            Assert.AreEqual(expected, math.Division(a, b));
        }

    }
}
