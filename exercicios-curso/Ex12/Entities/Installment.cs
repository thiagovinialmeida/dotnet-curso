using System.Text;

namespace Ex12.Entities
{
    internal class Installment
    {
        public DateTime DueDate { get; set; }
        public double Amount { get; set; }

        public Installment(DateTime dueDate, double amount)
        {
            DueDate = dueDate;
            Amount = amount;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{DueDate.ToString("dd/MM/yyyy")} - US${Amount:F2}");
            return sb.ToString();
        }
    }
}
