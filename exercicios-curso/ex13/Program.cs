using Ex13.Entities;

namespace Ex13
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<Studant> studant = new HashSet<Studant>();
            Console.Write("How many stydents for course A: ");
            int quantityA = int.Parse(Console.ReadLine());
            InputStudentId(quantityA);
            Console.Write("How many stydents for course B: ");
            int quantityB = int.Parse(Console.ReadLine());
            InputStudentId(quantityB);
            Console.Write("How many stydents for course C: ");
            int quantityC = int.Parse(Console.ReadLine());
            InputStudentId(quantityC);

            Console.WriteLine("Total students: " + studant.Count);

            void InputStudentId(int quantity)
            {
                for (int i = 0; i < quantity; i++)
                {
                    studant.Add(new Studant(int.Parse(Console.ReadLine())));
                }
            }
        }
    }
}