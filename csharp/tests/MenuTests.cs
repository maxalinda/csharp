using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.tests
{
    [TestFixture]
    class MenuTests
    {

        [Test]
        public void defineNumberTest()
        {
            bool isEven = DefineNumber.isEven(8);
            Assert.True(isEven);
        }
        [Test]
        public void defineNumberTest1()
        {
            bool isOdd = DefineNumber.isEven(7);
            Assert.False(isOdd);
        }
        [Test]
        public void defineNumberTest2()
        {
            string isOdd = DefineNumber.evenOrOdd("5");
            Assert.NotNull(isOdd);
            Assert.AreEqual("isOdd", isOdd);
        }
        [Test]
        public void defineNumberTest3()
        {
            string isEven = DefineNumber.evenOrOdd("4");
            Assert.NotNull(isEven);
            Assert.AreEqual("isEven", isEven);

        }
        [Test]
        public void defineNumberTest4()
        {
            string wrongData = DefineNumber.evenOrOdd("*");
            Assert.NotNull(wrongData);
            Assert.AreEqual("WrongData", wrongData);
        }
    }
}
