using Ex07.Entities;
using Ex07.Entities.Enums;

namespace Ex07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter client data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Email: ");
            string email = Console.ReadLine();
            Console.Write("Birth date (dd/MM/yyyy): ");
            DateTime birthday = DateTime.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter order data: ");
            Console.Write("Status: ");
            OrderStatus status = Enum.Parse<OrderStatus>(Console.ReadLine());
            Console.Write("How many items to this order? ");
            int items = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Client client = new Client(name, email, birthday);
            Order order = new Order(status, client);

            for (int i = 0; i < items; i++)
            {
                Console.WriteLine($"Enter #{i + 1} item data:");
                Console.Write("Product name: ");
                string pname = Console.ReadLine();
                Console.Write("Product price: ");
                double price = double.Parse(Console.ReadLine());
                Console.Write("Quantity: ");
                int quantity = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Product product = new Product(pname, price);
                OrderItem item = new OrderItem(quantity, price, product);

                order.AddItem(item);
            }
            Console.Clear();
            Console.WriteLine(order);
        }
    }
}