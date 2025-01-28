namespace Dictionaty
{
    class Program
    {
        static void Main()
        {
            Dictionary<string, string> cookies = new Dictionary<string, string>();

            cookies["user"] = "maria";
            cookies["email"] = "maria@gmail.com";
            cookies["phone"] = "992112045";
            cookies["phone"] = "110940390";

            Console.WriteLine(cookies["email"]);
            Console.WriteLine(cookies["phone"]);

            Console.WriteLine(cookies.Count);
            foreach (KeyValuePair<string,string> item in cookies)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }
        }
    }
}