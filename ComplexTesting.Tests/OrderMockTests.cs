using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace ComplexTesting.Tests
{ 
    [TestClass]
    public class OrderMockTests
    {
        [TestMethod]
        public void ShouldCheckoutWithOneItem()
        {
            // Arrange
            var mockPaymentService = Substitute.For<IPaymentService>();
            mockPaymentService
                .ValidatePayment(Arg.Any<double>())
                .Returns(true);

            var order = new Order(mockPaymentService);
            order.AddItemToOrder(7.99);
            
            // Act
            var result = order.Checkout();

            // Assert
            result.Should().BeTrue();
            mockPaymentService.Received(1).ValidatePayment(7.99 * 1.0825);
        }
    }
}