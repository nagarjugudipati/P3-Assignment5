using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    [TestFixture]
    public class TestCalc
    {
        [Test]
        public void AddTest()
        {
            Arithmatic calculator = new Arithmatic();
            double num1 = 10;
            double num2 = 10;

            double result = num1 + num2;

            Assert.AreEqual(result, calculator.Add(10, 10));
        }

        [Test]
        public void SubTractTest()
        {
            Arithmatic calculator = new Arithmatic();
            double num1 = 10;
            double num2 = 10;

            double result = num1 - num2;

            Assert.AreEqual(result, calculator.Sub(10, 10));
        }

        [Test]
        public void DivideTest()
        {
            Arithmatic calculator = new Arithmatic();
            double num1 = 10;
            double num2 = 10;

            double result = num1 / num2;

            Assert.AreEqual(result, calculator.Div(10, 10));
        }

        [Test]
        public void MultiplyTest()
        {
            Arithmatic calculator = new Arithmatic();
            double num1 = 10;
            double num2 = 10;

            double result = num1 * num2;

            Assert.AreEqual(result, calculator.Mul(10, 10));
        }
    }
}
