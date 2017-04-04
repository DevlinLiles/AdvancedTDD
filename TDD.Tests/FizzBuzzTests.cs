using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TDD.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        [DataRow(1)]
        [DataRow(2)]
        [DataRow(4)]
        public void ShouldGiveNumberCorrectly(int number)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GenerateNumberAnswer(number);

            // Assert
            result.Should().Be(number.ToString());
        }

        [TestMethod]
        [DataRow(3)]
        [DataRow(6)]
        [DataRow(9)]
        [DataRow(12)]
        public void ShouldGiveFizzCorrectly(int number)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GenerateNumberAnswer(number);

            // Assert
            result.Should().Be("Fizz");
        }

        [TestMethod]
        [DataRow(5)]
        [DataRow(10)]
        [DataRow(20)]
        public void ShouldGiveBuzzCorrectly(int number)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GenerateNumberAnswer(number);

            // Assert
            result.Should().Be("Buzz");
        }

        [TestMethod]
        [DataRow(15)]
        [DataRow(30)]
        public void ShouldGiveFizzBuzzCorrectly(int number)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            var result = fizzBuzz.GenerateNumberAnswer(number);

            // Assert
            result.Should().Be("FizzBuzz");
        }

        [TestMethod]
        [DataRow(-1)]
        [DataRow(0)]
        [DataRow(101)]
        public void ShouldThrowErrorOutsideRange(int number)
        {
            // Arrange
            var fizzBuzz = new FizzBuzz();

            // Act
            Action action = () => fizzBuzz.GenerateNumberAnswer(number);

            // Assert
            action.ShouldThrow<ArgumentOutOfRangeException>();
        }
    }
}
