using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.DesignPattern.FactoryMethod
{
    internal class UPIPayment : IPayment
    {
        public Guid Pay(decimal amount)
        {
            Console.WriteLine($"UPI payment of {amount} is successfull");
            return Guid.NewGuid();
        }
    }

    internal class UPIPaymentFactory : PaymentFactory
    {
        public override IPayment CreatePayment()
        {
            return new UPIPayment();
        }
    }
}
