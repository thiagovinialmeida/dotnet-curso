namespace Ex02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Seja bem-vindo a área de gestão. O que gostaria de fazer?");
            Console.WriteLine("1 - Para adicionar qunatidade de produto ao estoque");
            Console.WriteLine("2 - Para remover quantidade de produto ao estoque");
            Console.WriteLine("3 - Para calcular o total das unidades em estoque");
            
            int num = int.Parse(Console.ReadLine()); 
            Produtos produtos = new Produtos();

            switch (num)
            {
                case 1:
                    {
                        Console.WriteLine("Quantos unidades adcionar?");
                        produtos.SomarEstoque(int.Parse(Console.ReadLine())); 
                        Console.WriteLine($@"Dados atualizados
Nome: {produtos.Nome}
Preço: R${produtos.Preco:F2}
Possui: {produtos.Estoque} unidades no total de R${produtos.TotalCalc():F2}");
                        Console.ReadKey();
                        break;
                    }

                case 2:
                {
                        Console.WriteLine("Quantas unidades quer remover do sistema?");
                        produtos.SubtrairEstoque(int.Parse(Console.ReadLine()));
                        Console.WriteLine($@"Dados atualizados
Nome: {produtos.Nome}
Preço: R${produtos.Preco:F2}
Possui: {produtos.Estoque} unidades no total de R${produtos.TotalCalc():F2}");
                        Console.ReadKey();
                        break;
                }

                case 3:
                {
                        Console.WriteLine($@"Dados atualizados
Nome: {produtos.Nome}
Preço: R${produtos.Preco:F2}
Possui: {produtos.Estoque} unidades no total de R${produtos.TotalCalc():F2}");
                        Console.ReadKey();
                        break;
                }

                default:
                    {
                        Console.WriteLine("Opção invalida!");
                        break;
                    }
            }
        }
    }
}