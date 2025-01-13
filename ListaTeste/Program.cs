namespace ListaTeste
{
    class Program
    {
        static void Main()
        {


            Console.Write("Insira o número de funcionarios:");
            int funcionariosNum = int.Parse(Console.ReadLine());
            List<Equipe> equipe = new List<Equipe>();

            for (int i = 0; i < funcionariosNum; i++)
            {
                Console.WriteLine($"Ficha do funcionario #{i+1}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string name = Console.ReadLine();
                Console.Write("Salario: ");
                double salario = double.Parse(Console.ReadLine());

                equipe.Add(new Equipe(id, name, salario));
                Console.WriteLine("");
            }

            Console.Write("Entre com o ID do funicionario que vai receber um aumento: ");
            int idSearch = int.Parse(Console.ReadLine());
            Equipe equi = equipe.Find(x => x.Id == idSearch);
            if (equi != null)
            {
                Console.Write("Entre com a porcentagem:");
                equi.Aumento(double.Parse(Console.ReadLine()));
                Console.WriteLine("");
            } else
            {
                Console.WriteLine("");
                Console.WriteLine("O Id informado não existe.");
                Console.WriteLine("");
            }

            Console.WriteLine("Lista Atualizada: ");
            Console.WriteLine("-----------------------");
            foreach (Equipe item in equipe)
            {
                Console.Write("ID:");
                Console.WriteLine(item.Id);
                Console.Write("Nome: ");
                Console.WriteLine(item.Name);
                Console.Write("Salário: ");
                Console.WriteLine($"R$ {item.Salario:F2}");
                Console.WriteLine("-----------------------");
            }
        }
    }
}