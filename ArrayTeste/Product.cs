namespace ArrayTeste
{
    class Product
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }


        public Product()
        {
           
        }
        public Product(string name, string email, int room)
        {
            Name = name;
            Email = email;
            Room = room;
        }

    }
}
