using HashsetAndSortedset.Entities;

namespace HashsetAndSortedset
{
    class Program
    {
        static void Main(string[] args)
        {
            /*SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
            SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

            //Union
            SortedSet<int> c = new SortedSet<int>(a);
            c.UnionWith(b);

            PrintCollection(c);

            //Intersection
            SortedSet<int> d = new SortedSet<int>(a);
            d.IntersectWith(b);

            PrintCollection(d);

            //Diferrence
            SortedSet<int> e = new SortedSet<int>(a);
            e.ExceptWith(b);

            PrintCollection(e);

            //Equal test
            HashSet<string> set = new HashSet<string>();

            set.Add("Maria");
            set.Add("Alex");

            Console.WriteLine(set.Contains("Maria"));*/


            HashSet<Product> a = new HashSet<Product>();
            a.Add(new Product("TV", 900.0));
            a.Add(new Product("Notebook", 1200.0));

            HashSet<Point> b = new HashSet<Point>();
            b.Add(new Point(3, 4));
            b.Add(new Point(5, 10));

            Product prod = new Product("Notebook", 1200.0);
            Console.WriteLine(a.Contains(prod));

            Point p = new Point(5, 10);
            Console.WriteLine(b.Contains(p));
        }

        static void PrintCollection<T>(IEnumerable<T> collection)
        {
            foreach (T item in collection)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}