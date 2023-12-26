using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.DesignPattern.FactoryMethod
{
    internal class CreditCardPayment : IPayment
    {
        public Guid Pay(decimal amount)
        {
            Console.WriteLine($"Credit card payment of { amount} is successfull");
            return Guid.NewGuid();
        }
    }

    internal class CreditCardPaymentFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new CreditCardPayment();
        }
    }
}
