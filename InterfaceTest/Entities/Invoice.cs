using System.Text;

namespace InterfaceTest.Entities
{
    internal class Invoice
    {
        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine();
            sb.AppendLine("INVOICE:");
            sb.AppendLine($"Basic payment: US${BasicPayment:F2}");
            sb.AppendLine($"Tax: US${Tax:F2}");
            sb.AppendLine($"Total payment: US${TotalPayment:F2}");
            return sb.ToString();
        }
    }
}
