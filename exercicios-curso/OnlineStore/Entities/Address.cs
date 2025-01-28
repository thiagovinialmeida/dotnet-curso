using System.Text;

namespace OnlineStore.Entities
{
    internal sealed class Address : Customer
    {
        public string Street { get; private set; }
        public string City { get; private set; }
        public string Region { get; private set; }
        public string Country { get; private set; }
        public int PostalCode { get; private set; }

        public Address(string password) : base(password)
        {
        
        }

        public Address(string name, int id, string password, string sendAddress, string billingAddress, string street, string city, string region, string country, int postalCode) : base(name, id, password, sendAddress, billingAddress)
        {
            Street = street;
            City = city;
            Region = region;
            Country = country;
            PostalCode = postalCode;
        }

        public string Show()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Customer #{Id}");
            sb.AppendLine($"{Name} - {Country}");
            sb.AppendLine($"Sending address: {Street}, {City}({Region}).");
            sb.AppendLine($"Postal code: {PostalCode}");

            return sb.ToString();
        }
    }
}
