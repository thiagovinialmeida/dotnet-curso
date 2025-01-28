using Ex14.Entites;

namespace Ex14
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Candidate> candidate = new Dictionary<string, Candidate>();
            Console.Write("Enter file full path: ");
            string path = Console.ReadLine();
            
            using (StreamReader sr = File.OpenText(path))
            {
                while (!sr.EndOfStream)
                {
                    string[] lines = sr.ReadLine().Split(';');

                    if (candidate.ContainsKey(lines[0]))
                    {
                        candidate[lines[0]].Votes += int.Parse(lines[1]);
                    }
                    else
                    {
                        candidate.Add(lines[0], new Candidate(lines[0], int.Parse(lines[1])));
                    }
                }

                foreach (KeyValuePair<string, Candidate> item in candidate)
                {
                    Console.WriteLine($"{item.Value.Name}: {item.Value.Votes} votes");
                }
            }
        }
    }
}