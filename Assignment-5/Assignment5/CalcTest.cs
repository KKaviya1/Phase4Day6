using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void AddTest()
        {
            Calculator cal = new Calculator();
            double num1 = 5;
            double num2 = 5;

            double result = num1 + num2;

            Assert.AreEqual(result, cal.Add(5, 5));
        }

        [Test]
        public void SubTractTest()
        {
            Calculator cal = new Calculator();
            double num1 = 5;
            double num2 = 5;

            double result = num1 - num2;

            Assert.AreEqual(result, cal.Sub(5, 5));
        }

        [Test]
        public void DivideTest()
        {
            Calculator cal = new Calculator();
            double num1 = 5;
            double num2 = 5;

            double result = num1 / num2;

            Assert.AreEqual(result, cal.Div(5, 5));
        }

        [Test]
        public void MultiplyTest()
        {
            Calculator cal = new Calculator();
            double num1 = 5;
            double num2 = 5;

            double result = num1 * num2;

            Assert.AreEqual(result, cal.Mul(5, 5));
        }
    }
}
