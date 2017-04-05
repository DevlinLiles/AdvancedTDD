using System;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BDD.Tests
{
    [TestClass]
    public class AdditionBehavior
    {
        private BDD.Calculator _calculator;

        [TestInitialize]
        public void Setup()
        {
            _calculator = new BDD.Calculator();
        }

        [TestMethod]
        public void ShouldAddTwoNumbersCorrectly()
        {
            var result = _calculator.Add(3938, 1);

            result.Should().Be(3939);
        }

        [TestMethod]
        public void ShouldSupportNegativeNumbers()
        {
            var result = _calculator.Add(-230, -230);

            result.Should().Be(-460);
        }

        [TestMethod]
        public void ShouldSupportAddingNegativeAndPositiveNumbersTogether()
        {
            var result = _calculator.Add(-230, 60);

            result.Should().Be(-170);
        }

        [TestMethod]
        public void ShouldReturnReallyBigIntegers()
        {
            var result = _calculator.Add(Int32.MaxValue, 2);

            long expected = 2l + Int32.MaxValue;

            result.Should().Be(expected);
        }

        [TestMethod]
        public void ShouldGiveAReadableErrorMessageWhenItCannotAddNumbers()
        {
            Action action = () => _calculator.Add(long.MaxValue, long.MaxValue);

            action.ShouldThrow<InvalidOperationException>().Which.Message.Should().Be("Unable to add values");
        }
    }
}
