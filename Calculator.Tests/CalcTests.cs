using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute.ExceptionExtensions;

namespace Calculator.Tests
{
    [TestClass]
    public class CalcTests
    {
        [TestMethod]
        public void ShouldAddTwoNumbers()
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Add(2, 2);

            // Assert
            // Assert.AreEqual(4, result);
            result.Should().Be(4);
        }

        [TestMethod]
        public void ShouldGuardAgainstIntMax()
        {
            // Arrange
            var calc = new Calc();

            // Act
            Action action = () => calc.Add(int.MaxValue, 2);

            // Assert
            action.ShouldThrow<InvalidOperationException>();

            //try
            //{
            //    action();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    return;
            //}
            //Assert.Fail("No Exception");
        }

        [TestMethod]
        public void ShouldSubtractTwoNumbers()
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Subtract(2, 2);

            // Assert
            // Assert.AreEqual(4, result);
            result.Should().Be(0);
        }

        [TestMethod]
        public void ShouldGuardAgainstIntMin()
        {
            // Arrange
            var calc = new Calc();

            // Act
            Action action = () => calc.Subtract(int.MinValue, 2);

            // Assert
            action.ShouldThrow<InvalidOperationException>();

            //try
            //{
            //    action();
            //}
            //catch (InvalidOperationException ex)
            //{
            //    return;
            //}
            //Assert.Fail("No Exception");
        }

        [TestMethod]
        [DataRow(1, 1, 2)]
        [DataRow(100, 1, 101)]
        public void ShouldAddNumbers(int one, int two, int expected)
        {
            // Arrange
            var calc = new Calc();

            // Act
            var result = calc.Add(one, two);

            // Assert
            result.Should().Be(expected);
        }

        [TestMethod]
        [DataRow(int.MaxValue, 2, typeof(InvalidOperationException))]
        [DataRow(2, int.MaxValue, typeof(InvalidOperationException))]
        public void ShouldErrorOnAdd(int one, int two, Type exception)
        {
            // Arrange
            var calc = new Calc();

            // Act
            Action action = () => calc.Add(one, two);

            // Assert
            action.ShouldThrow(exception);
            try
            {
                action();
            }
            catch (Exception e)
            {
                e.Should().BeAssignableTo(exception);
                return;

            }
            Assert.Fail();
        }
    }

    public static class ActionExtensions
    {
        public static Exception ShouldThrow(this Action action, Type expectedException)
        {
            try
            {
                action();
            }
            catch (Exception e)
            {
                e.Should().BeAssignableTo(expectedException);
                return e;

            }
            Assert.Fail();
            return null;
        }
    }
}
