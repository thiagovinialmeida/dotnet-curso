using Ex09.Entities;

namespace Ex09
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            Console.Write("Enter the number of products: ");
            int productsNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < productsNum; i++)
            {
                Console.WriteLine($"Product #{i+1} data: ");
                Console.Write("Common, used or imported(c/u/i)? ");
                char answer = char.Parse(Console.ReadLine().ToLower());
                while( answer != 'c' && answer != 'u' && answer != 'i')
                {
                    Console.WriteLine("INVALID ANSWERE! - TRY AGAIN");
                    answer = char.Parse(Console.ReadLine());
                }
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Price: ");
                double price = int.Parse(Console.ReadLine());
                
                if (answer == 'i')
                {
                    Console.Write("Customs Fee: ");
                    double customsFee = double.Parse(Console.ReadLine());
                    products.Add(new ImportedProduct(name, price, customsFee));
                }
                else if(answer == 'u')
                {
                    Console.Write("Manufacture Date(dd/MM/yyyy): ");
                    DateTime manufactureDate = DateTime.Parse(Console.ReadLine());
                    products.Add(new UsedProduct(name, price, manufactureDate));
                }
                else
                {
                    products.Add(new Product(name, price));
                }
            }

            Console.WriteLine();
            Console.WriteLine("PRICE TAGS:");
            foreach (var item in products)
            {
                Console.WriteLine(item.PriceTag());
            }
        }
    }
}