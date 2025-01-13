namespace Ex10.Entities
{
    internal abstract class Taxpayers
    {
        public string Name { get; protected set; }
        public double AnualIncome { get; protected set; }

        public Taxpayers() { }

        public Taxpayers(string name, double anualIncome)
        {
            Name = name;
            AnualIncome = anualIncome;
        }

        public abstract double Tax();
    }
}
