using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp.tests
{
    [TestFixture]
    class PrimitiveConvectorTests
    {
        PrimitiveConvector convector = new PrimitiveConvector();

        //FLOAT TO CHAR====================================================
        [Test]
        public void floatToCharTestType()
        {
            float test = 3.1489F;
            char result = convector.floatToChar(test);         
            Assert.IsInstanceOf<Char>(result);
        }
        [Test]
        public void floatToCharTest() {
           float test = 3.1489F;
           char result = convector.floatToChar(test);
           Assert.AreEqual('\u0003', result);
           Assert.IsInstanceOf<Char>(result);       
        }
        [Test]
        public void floatToCharTest2()
        {
            float test = 3.1489F;
            char result = convector.floatToChar(test);
            Assert.AreNotEqual('!', result);
        }
        [Test]
        public void floatToCharTest3()
        {
            float test = 3.1489F;
            char result = convector.floatToChar(test);
            Assert.AreNotSame(test, result);
        }
        [Test]
        public void floatToCharTest4()
        {
            float test = 3.1489F;
            char result = convector.floatToChar(test);
            Assert.IsNotNull(result);
        }

        //INT TO CHAR===============================================================
        [Test]
        public void intToCharTestType()
        {
            int test = 1488;
            char result = convector.intToChar(test);
            Assert.IsInstanceOf<Char>(result);
        }
        [Test]
        public void intToCharTest()
        {
            int test = 1488;
            char result = convector.intToChar(test);
            Assert.AreEqual('א', result);
        }
        [Test]
        public void intToCharTest2()
        {
            int test = 1488;
            char result = convector.intToChar(test);
            Assert.AreNotEqual('!', result);
        }
        [Test]
        public void intToCharTest3()
        {
            int test = 1488;
            char result = convector.intToChar(test);
            Assert.AreNotSame(test, result);
        }
        [Test]
        public void intToCharTest4()
        {
            int test = -28;
            char result = convector.intToChar(test);
            Assert.IsNotNull(result);
        }

        //CHAR TO INT================================================================
        [Test]
        public void charToIntTestType()
        {
            char test = 'א';
            int result = convector.charToInt(test);
            Assert.IsInstanceOf<Int32>(result);
        }
        [Test]
        public void charToIntTest()
        {
            char test = 'א';
            int result = convector.charToInt(test);
            Assert.AreEqual(1488, result);
        }
        [Test]
        public void charToIntTest2()
        {
            char test = '?';
            int result = convector.charToInt(test);
            Assert.AreNotEqual(1488, result);
        }
        [Test]
        public void charToIntTest3()
        {
            char test = '?';
            int result = convector.charToInt(test);
            Assert.AreNotSame(test, result);
        }
        [Test]
        public void charToIntTest4()
        {
            char test = '*';
            int result = convector.charToInt(test);
            Assert.IsNotNull(result);
        }
        [Test]
        public void charToIntTest5()
        {
            char test = '-';
            int result = convector.charToInt(test);
            Assert.Greater(result, 1);
        }
        [Test]
        public void charToIntTest6()
        {
            char test = '-';
            int result = convector.charToInt(test);
            Assert.GreaterOrEqual(result, 45);
        }
        [Test]
        public void charToIntTest7()
        {
            char test = '-';
            int result = convector.charToInt(test);
            Assert.Less(result, 100);
        }
        [Test]
        public void charToIntTest8()
        {
            char test = '-';
            int result = convector.charToInt(test);
            Assert.LessOrEqual(result, 45);
        }
        [Test]
        public void charToIntTest9()
        {
            char test = '￤';
            int result = convector.charToInt(test);
            Assert.Positive(result);
        }
        [Test]
        public void charToIntTest10()
        {
            char test = '~';
            int result = convector.charToInt(test);
            Assert.NotZero(result);
        }


        //DOUBLE TO INT=====================================================
        [Test]
        public void doubleToIntTestType()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.IsInstanceOf<Int32>(result);
        }
        [Test]
        public void doubleToIntTest()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.AreEqual(25, result);
        }
        [Test]
        public void doubleToIntTest2()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.AreNotEqual(9090, result);
        }
        [Test]
        public void doubleToIntTest3()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.AreNotSame(test, result);
        }
        [Test]
        public void doubleToIntTest4()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.IsNotNull(result);
        }
        [Test]
        public void doubleToIntTest5()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.Greater(result, 1);
        }
        [Test]
        public void doubleToIntTest6()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.GreaterOrEqual(result, 25);
        }
        [Test]
        public void doubleToIntTest7()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.Less(result, 100);
        }
        [Test]
        public void doubleToIntTest8()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.LessOrEqual(result, 25);
        }
        [Test]
        public void doubleToIntTest9()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.Positive(result);
        }
        [Test]
        public void doubleToIntTest10()
        {
            double test = -25.34;
            int result = convector.doubleToInt(test);
            Assert.Negative(result);
        }
        [Test]
        public void doubleToIntTest11()
        {
            double test = 25.34;
            int result = convector.doubleToInt(test);
            Assert.NotZero(result);
        }

    }
}
