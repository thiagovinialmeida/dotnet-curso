namespace OnlineStore.Entities
{
    internal class Customer
    {
        public string Name { get; private set; }
        public int Id { get; private set; }
        public string Password { get; private set; }
        public string SendAddress { get; private set; }
        public string BillingAddress { get; private set; }

        public Customer(string password)
        {
            Password = password;
        }

        public Customer(string name, int id, string password, string sendAddress, string billingAddress)
        {
            Name = name;
            Id = id;
            Password = password;
            SendAddress = sendAddress;
            BillingAddress = billingAddress;
        }

        public string Validate(string xPassword)
        {
            int value = 0;
            while (xPassword != Password && value < 3)
            {
                value++;
                Console.WriteLine("Wrong password! Try again.");
                xPassword = Console.ReadLine();
            }

            if (value >= 3)
            {
                return "Login section are blocked.";
            }

            if (xPassword == Password)
            {
                Console.Clear();
                return @"
                        Correct password.
                        Logged
                ";
            }
            else
            {
                return "The password is wrong";
            }
        }

        public void GetCard()
        {

        }

        public void Invoice()
        {

        }
    }
}
