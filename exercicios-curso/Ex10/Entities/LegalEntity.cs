using System;

namespace Ex10.Entities
{
    internal sealed class LegalEntity : Taxpayers
    {
        public int Workers { get; set; }

        public LegalEntity(string name, double anualIncome, int workers) : base(name, anualIncome)
        {
            Workers = workers;
        }

        public override double Tax()
        {
            return (Workers >= 10) ? AnualIncome * 0.14 : AnualIncome * 0.16; ;
        }
    }
}
