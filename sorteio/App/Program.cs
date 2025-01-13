namespace Sorteio
{
    class Program
    {
        public static void Main()
        {
            Random rnd = new Random();
            int roleta = rnd.Next(10);
            Console.WriteLine($@"Seja bem vindo a um jogo simples e fácil de Tente acertar o numero! Por favor, escolha um número!");

            if(roleta == 0)
            {
                roleta++;
            }
            Tentar(roleta);
        }

        public static void Tentar(int x)
        {
            int chute = Convert.ToInt32(Console.ReadLine());

            if(chute > 10 || chute <= 0 )
            {
                Console.WriteLine("O número escolhido ultrapassa os valores permitidos. Por favor, escolha um número entre 1 e 10");
                Tentar(x);
            }
            else if(chute > x)
            {
                Console.WriteLine("O número chutado é maior do que o esperado. Tente novamente!");
                Tentar(x);
            } 
            else if(chute < x)
            {
                Console.WriteLine("O número chutado é menor do que o esperado. Tente novamente!");
                Tentar(x);
            } 
            else 
            {
                Console.WriteLine("Correto!");
            }
        }
    }    
}