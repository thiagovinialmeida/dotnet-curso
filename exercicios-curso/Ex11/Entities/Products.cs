using System.Text;

namespace Ex11.Entities
{
    internal class Products
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }

        public Products() { }

        public Products(string name, double price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public double Total()
        {
            return Price * Quantity;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==========================");
            sb.AppendLine($"- Name: {Name.ToUpper()}");
            sb.AppendLine($"- Price: {Total():F2}");
            sb.AppendLine("==========================");

            return sb.ToString();
        }
    }
}
