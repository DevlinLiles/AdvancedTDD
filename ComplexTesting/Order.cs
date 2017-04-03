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
        private ICollection<double> _items;

        public Order(IPaymentService paymentService)
        {
            _paymentService = paymentService;
            _taxRate = 1.0825;
            _total = _items.Sum() * _taxRate;
        }

        public void AddItemToOrder(double price)
        {
            _items.Add(price);
        }

        public Boolean Checkout()
        {
            return _paymentService.ValidatePayment(_total);
        }
    }
}
