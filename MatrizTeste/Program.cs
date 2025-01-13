namespace MatrizTeste
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[,] mat = new int[2, 2];

            for (int i = 0; i < n; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < n; j++)
                {
                    mat[i, j] = int.Parse(values[j]);       
                }
            }

            Console.WriteLine("Main Diagonal: ");
            for (int i = 0;i < n; i++)
            {
                Console.Write(mat[i, i] + " "); 
            }
            Console.WriteLine();

            Console.WriteLine("Negative numbers: ");

            int count = 0;
            for(int i = 0; i < n; i++)
            {
                
                for (int j = 0; j < n; j++)
                {
                   if (mat[i, j] < 0)
                    {
                        count++;
                    }
                }
            }
        }
    }
}