using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace ComplexTesting.Tests
{
    [TestClass]
    public class OrderStubTests
    {
        [TestMethod]
        public void ShouldCheckoutSuccessfully()
        {
            // Arrange
            IPaymentService stubPaymentService = Substitute.For<IPaymentService>();
            stubPaymentService.ValidatePayment(Arg.Any<double>()).Returns(true);

            var order = new Order(stubPaymentService);
            order.AddItemToOrder(128737.90);

            // Act
            var result = order.Checkout();

            // Assert
            result.Should().BeTrue();
        }
    }
}
