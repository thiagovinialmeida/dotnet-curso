using Ex08.Entities;

namespace Ex08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of employees: ");
            int numEmployees = int.Parse(Console.ReadLine());
            List<Employee> emp = new List<Employee>();

            for (int i = 0; i < numEmployees; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Employee #{i + 1} data:");
                Console.Write("Outsourced (Y/n): ");
                char outsourced = char.Parse(Console.ReadLine().ToLower());
                while(outsourced != 'y' && outsourced != 'n')
                {
                    Console.WriteLine("INVALID ANSWER - TRY AGAIN");
                    outsourced = char.Parse(Console.ReadLine().ToLower());
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine());

                if (outsourced == 'y')
                {
                    Console.Write("Additional Charge: ");
                    double additionalCharge = double.Parse(Console.ReadLine()); 
                    emp.Add(new OutsourcedEmployee(name, hours, valuePerHour, additionalCharge));
                }
                else
                {
                    emp.Add(new Employee(name, hours, valuePerHour));
                }
            }
            Console.WriteLine();
            Console.WriteLine("============");
            Console.WriteLine("PAYMENTS: ");
            foreach (var item in emp)
            {
                Console.WriteLine($"{item.Name} - US${item.Payment():F2}");
            }
        }
    }
}