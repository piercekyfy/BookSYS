using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSYS.Models
{
    public class BookOrder
    {
        public Order Order { get; set; }
        public Book Book { get; set; }
        public double SalePrice { get; set; }
        public int Quantity { get; set; }

        public BookOrder() 
        { 
        
        }

        public BookOrder(Order order, Book book, double salePrice, int quantity)
        {
            Order = order;
            Book = book;
            SalePrice = salePrice;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return $"{Book.Title} * {Quantity} @ {SalePrice} ea";
        }
    }
}
