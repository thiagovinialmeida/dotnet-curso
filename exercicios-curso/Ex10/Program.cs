using Ex10.Entities;
using System;

namespace Ex10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Taxpayers> payersList = new List<Taxpayers>();
            Console.Write("Enter the number of tax payers: ");
            int taxpayersNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < taxpayersNum; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Tax Payer #{i + 1} data:");
                Console.Write("Individual or company(i/c)?");
                char resp = char.Parse(Console.ReadLine());
                //while (resp != 'i' && resp != 'c')
                //{
                //    Console.WriteLine("INVALID - CHOOSE AGAIN");
                //    resp = char.Parse(Console.ReadLine());
                //}
                if (resp == 'i')
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Health expenditures: ");
                    double heathExpenditures = double.Parse(Console.ReadLine());

                    payersList.Add(new NaturalPerson(name, anualIncome, heathExpenditures));
                }
                else
                {
                    Console.Write("Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Anual income: ");
                    double anualIncome = double.Parse(Console.ReadLine());
                    Console.Write("Number of employees: ");
                    int employeesNum = int.Parse(Console.ReadLine());

                    payersList.Add(new LegalEntity(name, anualIncome, employeesNum));
                }
            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");
            double sum = 0;
            foreach (Taxpayers item in payersList)
            {
                Console.WriteLine($"{item.Name}: US${item.Tax():F2}");
                sum = item.Tax();
            }
            Console.WriteLine();
            Console.WriteLine($"TOTAL TAXES: US${sum:F2}");
        }
    }
}