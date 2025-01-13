using AbstractClass.Entities;
using AbstractClass.Entities.Enums;

namespace AbstractClass
{
    class Program
    {
        static void Main()
        {
            List<Shape> shapes = new List<Shape>();
            Console.Write("Enter the number of shepes: ");
            int shapesNum = int.Parse(Console.ReadLine());

            for (int i = 0; i < shapesNum; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"Shape #{i + 1} data:");
                Console.Write("Rectangle or Circle(r/c)? ");
                char shapeResp = char.Parse(Console.ReadLine());
                while (shapeResp != 'r' && shapeResp != 'c')
                {
                    Console.WriteLine("INVALID SHAPE - CHOOSE ANOTHER AGAIN");
                    shapeResp = char.Parse(Console.ReadLine());
                }
                Console.Write("Color(Black/Blue/Red): ");
                string cResp = Console.ReadLine();
                while (cResp != "Black" && cResp != "Blue" && cResp != "Red")
                {
                    Console.WriteLine("INVALID COLOR - WRITE CORRECTLY");
                    cResp = Console.ReadLine();
                }
                Color color = Enum.Parse<Color>(cResp);
                if (shapeResp == 'r')
                {
                    Console.Write("Width: ");
                    double width = double.Parse(Console.ReadLine());
                    Console.Write("Height: ");
                    double height = double.Parse(Console.ReadLine());
                    shapes.Add(new Rectangle(color, width, height));

                }
                else
                {
                    Console.Write("Radius: ");
                    double radius = double.Parse(Console.ReadLine());
                    shapes.Add(new Circle(radius, color));
                }
            }
                   

                    Console.WriteLine();
                    Console.WriteLine("SHAPE AREAS:");
                    foreach (Shape item in shapes)
                    {
                        Console.WriteLine(item.Area().ToString("F2"));
                    }
        }
    }
}