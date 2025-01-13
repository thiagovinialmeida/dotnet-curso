namespace ListaTeste
{
    internal class Equipe
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salario { get; private set; }

        public Equipe()
        {}
        public Equipe(int id, string name, double salario)
        {
            Id = id;
            Name = name;
            Salario = salario;
        }

        public void Aumento(double porcent)
        {
            Salario += Salario * (porcent / 100);
        }
    }
}
