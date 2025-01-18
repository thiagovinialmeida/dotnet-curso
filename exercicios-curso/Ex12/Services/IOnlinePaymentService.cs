namespace Ex12.Services
{
    internal interface IOnlinePaymentService
    {
        public double SimpleInterest(double amount, int months);
        public double PaymentFee(double amount);
    }
}