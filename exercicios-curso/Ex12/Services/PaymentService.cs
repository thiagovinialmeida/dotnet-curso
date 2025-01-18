using Ex12.Entities;

namespace Ex12.Services
{
    internal class PaymentService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public PaymentService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessContract(Contract contract, int numOfInsttallments)
        {
            double basicQuota = contract.TotalValue / numOfInsttallments;
            for (int i = 1; i <= numOfInsttallments; i++)
            {
                DateTime date = contract.Date.AddMonths(i);
                double updatedQuota = basicQuota + _onlinePaymentService.SimpleInterest(basicQuota, i);
                double totalQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                
                contract.AddInstallment(new Installment(date, totalQuota));
            }
        }
    }
}