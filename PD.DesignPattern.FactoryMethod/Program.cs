namespace PD.DesignPattern.FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPayment payment = new CreditCardPaymentFactory().CreatePayment();

            PaymentGateway paymentGateway = new PaymentGateway(payment);
            paymentGateway.MakePayment(1200);

            Console.WriteLine("Hello, World!");
        }
    }
}