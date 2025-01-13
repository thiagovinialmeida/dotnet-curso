/*
Sugestão de ordem de implementação:

-Atributos privados
-Propriedades autoimplementadas
-Construtores
-Propriedades Customizadas
-Outros métodos da classe
 */

/*
Modificadoers de acesso:

Public
protected internal
internal
protected
private protected
private
*/

namespace Ex02
{
    //Classe instanciada
    internal class Produtos
    {
        //Atributos
        public string Nome { get; private set; }
        public double Preco { get; private set; }
        public int Estoque { get; private set; }

        //Construtor geral
        public Produtos() { Nome = "TV"; Preco = 900.00; Estoque = 10; }

        //Método Construtor
        public Produtos(string nome, double preco) : this()
        {
            Nome = nome;
            Preco = preco;
        }

        //Métodos
        public int SomarEstoque(int x)
        { 
            return Estoque += x; 
        }

        public int SubtrairEstoque(int y)
        {
            return Estoque -= y;
        }
        public double TotalCalc()
        {
            return Preco * Estoque;
        }
    }
}