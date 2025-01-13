namespace CompositionTest.Entities
{
    internal class HourContract
    {
        //Atributos auto implementados
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //Construtor padrão
        public HourContract() { }
        //Construtor especifico
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        //Método da classe
        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
