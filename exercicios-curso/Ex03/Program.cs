namespace Ex03
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Sejá bem-vindo ao conversor de real em dolar. Quanto gostaria de converter?");
            double quantia = double.Parse(Console.ReadLine());
            double reais = ConversorDeMoeda.Conversor(quantia);

            Console.WriteLine($"Você precisará de R${reais:F2} para comprar US${quantia:F2}");
        }
    }
}