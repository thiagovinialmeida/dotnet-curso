namespace Ex04
{
    internal class Contas
    {
        private string _Name;

        public int ContNum { get; private set; }
        public double Saldo { get; private set; }

        public Contas(int contNum, string name)
        {
            ContNum = contNum;
            Name = name;
        }

        public Contas(int contNum, string name, double depositoInicial) : this(contNum, name)
        { Depositar(depositoInicial); }

        public string Name
        {
            get { return _Name; }
            set { if (value.Length > 1)
                {
                    _Name = value;
                }
            }
        }

        public void Depositar(double x)
        {
            Saldo += x;
        }

        public void Sacar(double y)
        {
            Saldo -=  (y + 5.00);
        }
    }
}
