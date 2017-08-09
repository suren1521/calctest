﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculator.Tests
{
    [TestClass]
    public class CalculatorOpTest
    {
        [TestMethod]
        public void ShouldAddReturnNineWhenPassFiveandFour()
        {
            // Arrange
            CalculatorOp sut = new CalculatorOp();

            // Act
            int result = sut.Add(5, 4);

            // Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
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
