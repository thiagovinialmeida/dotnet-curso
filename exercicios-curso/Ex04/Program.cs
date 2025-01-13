namespace Ex04
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.Write("Seja bem-vindo ao Vod's Bank. Para Prosseguir, por favor, informe o número da conta: ");
            int contNum = int.Parse(Console.ReadLine());
            Console.Write("Entre com o nome do titular: ");
            string titular = Console.ReadLine();
            Console.Write("Hávera depósito inicial(S/N)? ");
            char resp = char.Parse(Console.ReadLine());
            double deposito = 00.0;

            if(resp == 's' || resp == 'S')
            {
                Console.Write("Valor de depósito inicial: ");
                deposito = double.Parse(Console.ReadLine());
            }

            Contas dados = new Contas(contNum, titular, deposito);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine($"Conta: {dados.ContNum}, Titular: {dados.Name}, saldo: R${dados.Saldo:F2}");

            Console.WriteLine("");

            Console.Write("Entre um valor para depósito:");
            dados.Depositar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta: {dados.ContNum}, Titular: {dados.Name}, saldo: R${dados.Saldo:F2}");

            Console.WriteLine("");

            Console.Write("Entre um valor para saque:");
            dados.Sacar(double.Parse(Console.ReadLine()));
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine($"Conta: {dados.ContNum}, Titular: {dados.Name}, saldo: R${dados.Saldo:F2}");
            if (dados.Saldo < 00.0)
            {
                Console.WriteLine($"Você está devendo: {dados.Saldo:F2}");
            }
        }
    }
}