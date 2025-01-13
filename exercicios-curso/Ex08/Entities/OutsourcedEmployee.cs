namespace Ex08.Entities
{
    internal sealed class OutsourcedEmployee : Employee
    {
        public double AdditionalCharge { get; protected set; }

        public OutsourcedEmployee() { }
        public OutsourcedEmployee(string name, int hours, double valuePerHour, double additionalCharge) : base(name, hours, valuePerHour) 
        { 
        AdditionalCharge = additionalCharge;
        }

        //Método selado e sobrescrito 
        public sealed override double Payment()
        {
            return base.Payment() + AdditionalCharge * 1.1;
        }
    }
}
