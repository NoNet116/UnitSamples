using Microsoft.VisualStudio.TestPlatform.TestHost;
using UnitSamples;

namespace Calculator.Tests
{
    public class Tests
    {

        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new UnitSamples.Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new UnitSamples.Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calculator = new UnitSamples.Calculator();
            Assert.That(calculator.Subtraction(15, 19) == -4);
        }

        [Test]
        public void Additional_MustReturnCorrectValue()
        {
            var calculator = new UnitSamples.Calculator();
            Assert.That(calculator.Additional(15, 19) == 34);
        }

        [Test]
        public void Miltiplication_MustReturnCorrectValue()
        {
            var calculator = new UnitSamples.Calculator();
            Assert.That(calculator.Miltiplication(15, 19) == 285);
        }

    }
}