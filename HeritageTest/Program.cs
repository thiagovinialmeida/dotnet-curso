using System.Xml.Linq;
using HeritageTest.Entities;

namespace HeritageTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(1001, "alex", 500.0);
            Account acc2 = new SavingsAccount(1002, "Maria", 500.0, 0.01);

            acc1.Withdraw(10);
            acc2.Withdraw(10);

            Console.WriteLine(acc1.Balance);
            Console.WriteLine(acc2.Balance);
        }
    }
}