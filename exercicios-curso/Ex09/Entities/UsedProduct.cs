namespace Ex09.Entities
{
    internal sealed class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }

        public UsedProduct() { }

        public UsedProduct(string name, double price, DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public sealed override string PriceTag()
        {
            return $"{Name} (USED) - US${Price:F2} | (Manufacture date: {ManufactureDate})";
        }
    }
}
