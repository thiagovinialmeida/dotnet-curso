using CompositionTest.Entities;
using CompositionTest.Entities.Enums;

namespace CompositionTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //Entrada de dados atráves de console
            Console.Write("Enter Department's name: ");
            string department = Console.ReadLine();
            Console.WriteLine("Enter worker data:");
            Console.Write("Name:");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine());
            Console.Write("how to many contracts to this worker? ");
            int ctcs = int.Parse(Console.ReadLine());

            //Instancias
            Department dept = new Department(department);
            Worker worker = new Worker(name, level, baseSalary, dept);

            for (int i = 0; i < ctcs; i++)
            {
                Console.WriteLine($"Enter #{i+1} contract data: ");
                Console.Write("Date (dd/MM/yyyy): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double value = double.Parse(Console.ReadLine());
                Console.Write("Duration (Hours): ");
                int duration = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, value, duration);
                worker.AddContract(contract);
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income(MM/yyyy): ");
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));
            Console.WriteLine($"Name: {worker.Name}");
            Console.WriteLine($"Department: {worker.Department.Name}");
            Console.WriteLine($"Income for {month}/{year}: US${worker.Income(year, month):F2}");
        }
    }
}