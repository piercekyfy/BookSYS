using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSYS.Models
{
    public class Order
    {
        public int? OrderId { get; set; } = null;
        public int ClientId { get; set; }
        public DateTime OrderDate { get; set; }
        public double Total { get; set; }
        public char Status { get; set; } = 'U';

        public Order()
        {

        }

        public Order(int orderId, int clientId, DateTime orderDate, double total, char status)
        {
            OrderId = orderId;
            ClientId = clientId;
            OrderDate = orderDate;
            Total = total;
            Status = status;
        }

        public override string ToString()
        {
            return $"Order ({OrderId} - {OrderDate.ToString("dd/MM/yy")}) by {ClientId}";
        }
    }
}
