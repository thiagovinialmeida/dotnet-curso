using EnumTest.Entities;
using EnumTest.Entities.Enums;

namespace EnumTest
{
    class Program
    {
        static void Main()
        {
            Order order = new Order
            {
                Id = 1080,
                Moment = DateTime.Now,
                Status = OrderStatus.PendingPayment
            };

            Console.WriteLine(order);
        }
    }
}