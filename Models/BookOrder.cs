using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSYS.Models
{
    public class BookOrder
    {
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public double SalePrice { get; set; }
        public int Quantity { get; set; }

        public BookOrder() 
        { 
        
        }

        public BookOrder(int orderId, int bookId, double salePrice, int quantity)
        {
            OrderId = orderId;
            BookId = bookId;
            SalePrice = salePrice;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{BookId} * {Quantity} @ {SalePrice} ea";
        }
    }
}
