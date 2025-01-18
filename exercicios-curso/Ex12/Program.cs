using System.Globalization;
using Ex12.Entities;
using Ex12.Services;

namespace Ex12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int contractNumber = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double contractValue = double.Parse(Console.ReadLine());
            Console.Write("Enter number of installments: ");
            int numOfInsttallments = int.Parse(Console.ReadLine());

            Contract contract = new Contract(contractNumber, date, contractValue);
            PaymentService paymentService = new PaymentService(new PaypalService());
            paymentService.ProcessContract(contract, numOfInsttallments);

            Console.WriteLine();
            Console.WriteLine("INSTALLMENTS: ");
            foreach (Installment instalment in contract.Installments)
            {
                Console.WriteLine(instalment);
            }
        }
    }
}