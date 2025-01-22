using Microsoft.VisualStudio.TestPlatform.TestHost;
using UnitSamples;

namespace Calculator.Tests
{
    public class Tests
    {

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            UnitSamples.Calculator calculator = new UnitSamples.Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            UnitSamples.Calculator calculator = new UnitSamples.Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        [Test]
        public void Division_MustThrowException()
        {
            UnitSamples.Calculator calculator = new UnitSamples.Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

    }
}