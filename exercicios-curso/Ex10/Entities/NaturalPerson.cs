namespace Ex10.Entities
{
    internal sealed class NaturalPerson : Taxpayers
    {
        public double HealthSpending { get; set; }
        public NaturalPerson(string name, double anualIncome, double healthSpending) : base(name, anualIncome)
        {
            HealthSpending = healthSpending;
        }

        public override double Tax()
        {
            double tax = (AnualIncome > 20000.00) ? AnualIncome * 0.25 : AnualIncome * 0.15;
            
            if(HealthSpending > 0)
            {
                tax = tax - (HealthSpending * 0.5) ;
            }
            
            return tax;
        }
    }
}
