using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSYS.Models
{
    public class Order
    {
        public int OrderId { get; set; }
        public Client Client { get; set; }
        public DateTime OrderDate { get; set; }
        public char Status { get; set; } = 'U';
        public bool Paid { get; set; }

        public Order()
        {

        }

        public Order(int orderId, Client client, DateTime orderDate, char status, bool paid)
        {
            OrderId = orderId;
            Client = client;
            OrderDate = orderDate;
            Status = status;
            Paid = paid;
        }

        public override string ToString()
        {
            return $"Order ({OrderId} - {OrderDate.ToString("dd/MM/yy")}) by {Client.Name}";
        }
    }
}
