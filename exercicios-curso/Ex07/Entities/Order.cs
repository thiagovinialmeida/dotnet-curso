using System.Text;
using Ex07.Entities.Enums;

namespace Ex07.Entities
{
    internal class Order
    {
        public DateTime Moment { get; private set; }
        public OrderStatus Status { get; private set; }
        public Client Client { get; private set; }
        public List<OrderItem> OrderItems { get; set; } = new List<OrderItem>();

        public Order() { }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            OrderItems.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            OrderItems.Remove(item);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem x in OrderItems)
            {
                sum += x.SubTotal();
            }
            return sum;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order Summary:");
            sb.Append("Order momment: ");
            sb.AppendLine(Moment.ToString("dd/MM/yyyy"));
            sb.Append("Order Status: ");
            sb.AppendLine(Status.ToString());
            sb.AppendLine($"Client: Name - {Client.Name} {Client.BirthDate.ToString("dd/MM/yyyy")} / Email - {Client.Email}");
            sb.AppendLine("Order Items:");
            foreach (OrderItem item in OrderItems)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine($"Total price: US${Total().ToString("F2")}");

            return sb.ToString();
        }
    }
}
