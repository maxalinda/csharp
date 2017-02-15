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
        //Define Number Tests==============================================================
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

        //Triangle Calculations Tests==============================================
        TriangleCalculation tri = new TriangleCalculation();

        [Test]
        public void triangleIsRightAngle() {
            string result = tri.isTriangleRightAngled("3", "4", "5");
            Assert.NotNull(result);
            Assert.IsInstanceOf<String>(result);
            Assert.AreEqual("RightAngle", result, "Triangle is not Right angle, but expected");
        }
        [Test]
        public void triangleNotRightAngle()
        {
            string result = tri.isTriangleRightAngled("2", "2", "5");
            Assert.NotNull(result);
            Assert.IsInstanceOf<String>(result);
            Assert.AreEqual("NotRightAngle", result, "Expected not right-angled");
        }
        [Test]
        public void triangleWrongData()
        {
            string result = tri.isTriangleRightAngled("o", "$", "5.89");
            Assert.NotNull(result);
            Assert.IsInstanceOf<String>(result);
            Assert.AreEqual("WrongData", result, "Expected wrongData error");
        }

        //Circle Area tests====================================================
        [Test]
        public void area1IsBigger() {
            string result = CircleArea.CalculateBiggerCicleArea("2.6", "2");
            Assert.NotNull(result);
            Assert.IsInstanceOf<String>(result);
            Assert.AreEqual("Area1", result, "Area1 isn't bigger");
        }
        [Test]
        public void area2IsBigger()
        {
            string result = CircleArea.CalculateBiggerCicleArea("2.4", "7.9");
            Assert.NotNull(result);
            Assert.IsInstanceOf<String>(result);
            Assert.AreEqual("Area2", result, "Area2 isn't bigger");
        }
        [Test]
        public void areasIsEqual()
        {
            string result = CircleArea.CalculateBiggerCicleArea("7", "7");
            Assert.NotNull(result);
            Assert.IsInstanceOf<String>(result);
            Assert.AreEqual("AreasEqual", result, "Areas is not Equal");
        }
        [Test]
        public void areasWrongData()
        {
            string result = CircleArea.CalculateBiggerCicleArea("3  &", " 4 ");
            Assert.NotNull(result);
            Assert.IsInstanceOf<String>(result);
            Assert.AreEqual("WrongData", result, "Wrong data expected");
        }

        //Circle Radius method tests
        [Test]
        public void radiusWrongData() {
            double result = CircleRadius.CalculateCicleArea(" ", 3.14);
            Assert.NotNull(result);
            Assert.IsInstanceOf<Double>(result);
            Assert.AreEqual(1.0403, result, "Wrong data expected");
        }
        [Test]
        public void radiusIsCorrect() {
            double result = CircleRadius.CalculateCicleArea("8.24", 3.14);
            Assert.NotNull(result);
            Assert.IsInstanceOf<Double>(result);
            Assert.AreNotEqual(1.0403, result, "Correct data show error");
            Assert.AreEqual(213.19846400000003d, result, "Cicle Area is not as expected");
        }
    }
}
