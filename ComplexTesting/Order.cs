using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ComplexTesting
{
    public class Order
    {
        private readonly IPaymentService _paymentService;
        private double _total;
        private double _taxRate;
        private ICollection<double> _items = new List<double>();

        public Order(IPaymentService paymentService)
        {
            _paymentService = paymentService;
            _taxRate = 1.0825;
        }

        public void AddItemToOrder(double price)
        {
            _items.Add(price);
        }

        public Boolean Checkout()
        {
            _total = _items.Sum() * _taxRate;
            return _paymentService.ValidatePayment(_total);
        }
    }
}
