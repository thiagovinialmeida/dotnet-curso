namespace ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa x, y, a, b;
            x = new Pessoa();
            y = new Pessoa();
            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Qual o nome da primeira pesssoa?");
            x.nameX = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            y.yearsX = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o nome da segunda pesssoa?");
            a.nameA = Console.ReadLine();
            Console.WriteLine("Qual sua idade?");
            b.yearsB = int.Parse(Console.ReadLine());

            if(y.yearsX > b.yearsB)
            {
                Console.WriteLine($"{x.nameX} é {y.yearsX - b.yearsB} anos mais velha do que {a.nameA}");
            } else
            {
                Console.WriteLine($"{a.nameA} é {b.yearsB - y.yearsX} anos mais velho do que {x.nameX}");
            }
        }
    }
}