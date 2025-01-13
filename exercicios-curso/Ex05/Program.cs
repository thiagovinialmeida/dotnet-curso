namespace Ex05
{
    class Program
    {
        static void Main(string[] args)
        {
            //Point p;
            //p.X = 10;
            //p.Y = 5;
            //Console.WriteLine(p);

            double? x = null;
            double? y = 10.0;

            Console.WriteLine(x.GetValueOrDefault());
            Console.WriteLine(y.GetValueOrDefault());

            Console.WriteLine(x.HasValue);
            Console.WriteLine(y.HasValue);

            if (x.HasValue)
            {
                Console.WriteLine(x.Value);
            }
            else
            {
                Console.WriteLine("X is null");
            }

            if (y.HasValue)
            {
                Console.WriteLine(y.Value);
            }
            else
            {
                Console.WriteLine("Y is null");
            }

            double z = x ?? 00.0;
            Console.WriteLine(z);
        }
    }
}