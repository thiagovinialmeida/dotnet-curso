namespace Ex12.Entities
{
    internal class Contract
    {
        public int ContractNumber { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract(int contractNumber, DateTime date, double totalValue)
        {
            ContractNumber = contractNumber;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public void AddInstallment(Installment instalment)
        {
            Installments.Add(instalment);
        }
    }
}
