using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Calculator = Calc.Calculator;

namespace Calculator.Test.Unit
{
    [TestFixture]
    class CalculatorTest
    {
        private Calc.Calculator uut;

        [SetUp]
        public void Setup()
        { uut = new Calc.Calculator();
            
        }
        //Testing Add
        [Test]
        public void AddPositive()
        {
            Assert.That(uut.Add(5.5,7.5),Is.EqualTo(13));
        }

        [Test]
        public void AddOneNegative()
        {
            Assert.That(uut.Add(5.5,-7.5),Is.EqualTo(-2));
        }

        [Test]
        public void AddDoubleNegative()
        {
            Assert.That(uut.Add(-5.5, -7.5), Is.EqualTo(-13));
        }

        [TestCase(5, 9, 14)]
        [TestCase(-3,5,2)]
        [TestCase(-4,-2,-6)]
        public void AddTest(int a, int b, int result)
        {
            Assert.That(uut.Add(a,b),Is.EqualTo(result));
        }

        //Testing subtract
        [Test]
        public void SubtractPositive()
        {
            Assert.That(uut.Subtract(3,9),Is.EqualTo(-6));
        }

        [Test]
        public void SubtractOneNegative()
        {
            Assert.That(uut.Subtract(3,-9),Is.EqualTo(12));
        }

        [Test]
        public void SubtractTwoNegative()
        {
            Assert.That(uut.Subtract(-3,-9),Is.EqualTo(6));
        }

        [TestCase(12, 4, 8)]
        [TestCase(-5,9,-14)]
        [TestCase(-3,-10,7)]
        public void SubtractTest(int a, int b, int result)
        {
            Assert.That(uut.Subtract(a,b),Is.EqualTo(result));
        }

        //Testing Power
        [Test]
        public void PowerPositive()
        {
            Assert.That(uut.Power(4,3),Is.EqualTo(64));
        }

        [Test]
        public void PowerOneNegativ()
        {
            Assert.That(uut.Power(4,-3),Is.EqualTo(0.016).Within(0.001));
        }

        [Test]
        public void PowerTwoNegative()
        {
            Assert.That(uut.Power(-4,-3),Is.EqualTo(-0.016).Within(0.001));
        }

        [TestCase(6, 5, 7776)]
        [TestCase(100,-3,0.000001)]
        public void PowerTest(double a, double b, double result)
        {
            Assert.That(uut.Power(a,b),Is.EqualTo(result).Within(1e-4).Or.EqualTo(result).Within(1e-7));
        }


        //Testing Multiply
        [Test]
        public void MultiplyPositive()
        {
            Assert.That(uut.Multiply(6,8),Is.EqualTo(48));
        }

        [Test]
        public void MultiplyOneNegative()
        {
            Assert.That(uut.Multiply(6,-8),Is.EqualTo(-48));
        }

        [Test]
        public void MultiplyTwoNegative()
        {
            Assert.That(uut.Multiply(-6,-8),Is.EqualTo(48));
        }

        [TestCase(12, 8, 96)]
        [TestCase(-4.5,6,-27)]
        [TestCase(-24.3,-3.4,82.62)]
        [TestCase(100,0,0)]
        public void MutiplyTest(double a, double b, double result)
        {
            Assert.That(uut.Multiply(a,b),Is.EqualTo(result));
        }
    }
}
