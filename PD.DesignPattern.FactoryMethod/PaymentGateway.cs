using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.DesignPattern.FactoryMethod
{
    internal class PaymentGateway
    {
        private IPayment _payment;
        public PaymentGateway(IPayment payment) 
        {
            _payment = payment;
        }
        public Guid MakePayment(decimal amt)
        {
            return _payment.Pay(amt);
        }
    }
}
