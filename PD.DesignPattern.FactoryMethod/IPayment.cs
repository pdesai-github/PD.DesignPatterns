using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PD.DesignPattern.FactoryMethod
{
    public interface IPayment
    {
        Guid Pay(decimal amount);
    }

    public abstract class PaymentFactory
    {
          public abstract IPayment CreatePayment();
    }
}
