using NUnit.Framework;

namespace Calculator.Tests
{
    [TestFixture]
    public class CalculatorOpTest
    {
        [Test]
        public void ShouldAddReturnNineWhenPassFiveandFour()
        {
            // Arrange
            CalculatorOp sut = new CalculatorOp();

            // Act
            int result = sut.Add(5, 4);

            // Assert
            Assert.AreEqual(9, result);
        }

        [Test]
        public void ShouldMulReturnTwentyWhenPassFiveandFour()
        {
            // Arrange
            CalculatorOp sut = new CalculatorOp();

            // Act
            int result = sut.Mul(5, 4);

            // Assert
            Assert.AreEqual(20, result);
        }
    }
}
