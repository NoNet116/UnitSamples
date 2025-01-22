using UnitSamples;
namespace NUnitSamples.Tests
{
    public class Tests
    {
        [Test]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.That(calculator.Division(200, 10) == 20);
        }

        [Test]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.That(calculator.Subtraction(300, 10) == 290);
        }

        [Test]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }

    }
}