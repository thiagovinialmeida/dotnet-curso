namespace TreinodeLogica
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] triX = [7.50, 4.50, 4.02];
            double[] triY = [3.00, 4.00, 5.00];
            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            x.A = triX[0];
            x.B = triX[1];
            x.C = triX[2];

            y.A = triY[0];
            y.B = triY[1];
            y.C = triY[2];

            double areaX = x.Calc();
            double areaY = y.Calc();

            Console.WriteLine($"a área do triangulo X é: {areaX:f4}");
            Console.WriteLine($"a área do triangulo Y é: {areaY:f4}");
        }
    }
}