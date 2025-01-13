namespace ArrayTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("How many rooms will be rented?");
            int num = int.Parse(Console.ReadLine());
            Product[] rooms = new Product[10];

            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("");
                Console.WriteLine($"Rent: #{i + 1}");
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("E-mail: ");
                string email = Console.ReadLine();
                Console.Write("Room: ");
                int room = int.Parse(Console.ReadLine());
                room--;

                rooms[room] = new Product { Name = name, Email = email, Room = room };
            }

            Console.Clear();

            Console.WriteLine("Qual opção deseja seguir?");
            Console.WriteLine("1 - Mostrar todos os quartos.");
            Console.WriteLine("2 - Mostrar quartos ocupados.");
            int res = int.Parse(Console.ReadLine());

            Console.WriteLine(" ");

            switch (res)
            {
                case 1:
                    {
                        Console.WriteLine("Quartos ocupados do pensionato:");
                        Console.WriteLine(" ");

                        for (int i = 0; i < 10; i++)
                        {
                            if (rooms[i] == null)
                            {
                                rooms[i] = new Product("Vazio", "--", 0);
                            }
                            Console.WriteLine($@"
                    Rent #{i + 1}
                    Name: {rooms[i].Name}
                    Email: {rooms[i].Email}
                    Room: {rooms[i].Room}
                    ");
                        }
                        break;
                    }

                case 2:
                    {
                        Console.WriteLine("Quartos ocupados do pensionato:");
                        Console.WriteLine(" ");

                        for (int i = 0; i < 10; i++)
                        {
                            if (rooms[i] != null)
                            {
                            Console.WriteLine($@"
                    Rent #{i + 1}
                    Name: {rooms[i].Name}
                    Email: {rooms[i].Email}
                    Room: {rooms[i].Room}
                    ");
                            }
                        }
                        break;
                }
            }
        }
    }
}