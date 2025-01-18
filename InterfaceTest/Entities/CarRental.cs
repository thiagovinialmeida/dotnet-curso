namespace InterfaceTest.Entities
{
    internal class CarRental
    {
        
        public DateTime Start { get; protected set; }
        public DateTime Finish { get; protected set; }
        public Vehicle Vehicle { get; protected set; }
        public Invoice Invoice { get; set; }

        public CarRental(DateTime start, DateTime finish, Vehicle vehicle)
        {
            Start = start;
            Finish = finish;
            Vehicle = vehicle;
            Invoice = null;
        }
    }
}
