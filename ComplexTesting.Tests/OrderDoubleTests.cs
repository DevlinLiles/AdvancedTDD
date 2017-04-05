using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;

namespace ComplexTesting.Tests
{
    [TestClass]
    public class OrderDoubleTests
    {
        [TestMethod]
        public void ShouldCheckoutSuccessfully()
        {
        }
    }

    public class Fakes
    {
        public static IPaymentService Declines
        {
            get { return Substitute.For<IPaymentService>(); }
        }
    }
}