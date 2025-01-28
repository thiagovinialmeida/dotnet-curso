using OnlineStore.Entities;

namespace OnlineStore
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter the password");
            string password = Console.ReadLine();

            Address customer = new Address(password);

            Console.WriteLine("SignIn");
            string validation = Console.ReadLine();
            Console.WriteLine(customer.Validate(validation)); 
            Console.WriteLine();
            Console.WriteLine(customer.Show());
        }
    }
}