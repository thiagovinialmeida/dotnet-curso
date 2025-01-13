namespace TreinodeLogica
{
     class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Calc()
        {
            double her = (A+B+C)/2;
            return Math.Sqrt(her*(her-A)*(her-B)*(her-C));
        }
    }
}
