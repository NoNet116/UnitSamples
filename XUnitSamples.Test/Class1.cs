using UnitSamples;
using Xunit;

namespace XUnitSamples.Test
{
    public class Class1
    {
        [Fact]
        public void Subtraction_MustReturnCorrectValue()
        {
            Calculator calculator = new Calculator();
            Assert.True(calculator.Subtraction(300, 10) == 290);
        }

        [Fact]
        public void Division_MustReturnCorrectValue()
        {
            var calculator = new Calculator();
            Assert.True(calculator.Division(200, 10) == 20);
        }

        [Fact]
        public void Division_MustThrowException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
        }

        [Fact]
        public void AdditionalMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Addition(50, 10, 34);
            Assert.Equal(94, result);
        }

        [Fact]
        public void MultiplicationMustReturnCorrectValue()
        {
            var calculator = new Calculator();
            int result = calculator.Multiplication(3, 2, 20);
            Assert.Equal(120, result);
        }
    }
}
