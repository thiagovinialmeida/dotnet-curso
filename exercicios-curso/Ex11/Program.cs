using System.Globalization;
using Ex11.Entities;

namespace Ex11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Products> prod = new List<Products>();
                string path = "C:\\Users\\SAMSUNG\\Documents\\dev\\dotnet-curso\\exercicios-curso\\Ex11\\products.csv";
                string[] lines = File.ReadAllLines(path);

                foreach (string line in lines)
                {
                    string[] cut = line.Split(',');
                    string name = cut[0];
                    double price = double.Parse(cut[1], CultureInfo.InvariantCulture);
                    int quantity = int.Parse(cut[2]);

                    prod.Add(new Products(name, price, quantity));
                }

                Directory.CreateDirectory("C:\\Users\\SAMSUNG\\Documents\\dev\\dotnet-curso\\exercicios-curso\\Ex11\\Out");
                string targetPath = "C:\\Users\\SAMSUNG\\Documents\\dev\\dotnet-curso\\exercicios-curso\\Ex11\\Out\\summary.csv";

                if (File.Exists(targetPath))
                {
                    File.Delete(targetPath);
                    foreach (Products product in prod)
                    {
                        Console.WriteLine(product);
                        using (StreamWriter sw = File.AppendText(targetPath))
                        {
                            sw.WriteLine($"{product.Name},{product.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                    }
                }
                else
                {
                    foreach (Products product in prod)
                    {
                        Console.WriteLine(product);
                        using (StreamWriter sw = File.AppendText(targetPath))
                        {
                            sw.WriteLine($"{product.Name},{product.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                        }
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occured");
                Console.WriteLine(e.Message);
            }
        }
    }
}