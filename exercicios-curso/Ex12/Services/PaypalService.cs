namespace Ex12.Services
{
    internal class PaypalService : IOnlinePaymentService
    {
        private double PaypalInterestTax = 0.01;
        private double PaymentTax = 0.02;
        public double SimpleInterest(double amount, int months)
        {
            return amount * PaypalInterestTax * months;
        }

        public double PaymentFee(double amount)
        {
            return PaymentTax * amount;
        }
    }
}