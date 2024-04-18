using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS.Forms.Admin
{
    public partial class frmBookPopularity : DBForm
    {
        public frmBookPopularity()
        {
            InitializeComponent();

            grdBooks.Columns.Add("colRanking", "Ranking");
            grdBooks.Columns.Add("colId", "BookId");
            grdBooks.Columns.Add("colTitle", "Title");
            grdBooks.Columns.Add("colAuthor", "Author");
            grdBooks.Columns.Add("colQuantity", "Quantity Sold");
            grdBooks.Columns.Add("colRevenue", "Revenue (€)");
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Order> orders = db.GetPaidOrders().ToList();

            if (orders.Count <= 0)
            {
                MessageBox.Show("No Orders exist in file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            List<Book> books = new List<Book>();
            Dictionary<int, int> bookOrdersQuantity = new Dictionary<int, int>();
            Dictionary<int, double> bookOrdersRevenue = new Dictionary<int, double>();

            foreach (Order order in orders)
            {
                List<BookOrder> bookOrders = db.GetBookOrdersByOrder(order.OrderId.Value).ToList();
                foreach (BookOrder bookOrder in bookOrders)
                {
                    Book book = db.GetBook(bookOrder.BookId);

                    if (books.Where(x => x.BookId == book.BookId).FirstOrDefault() == null)
                    {
                        books.Add(book);
                    }

                    if (bookOrdersQuantity.TryGetValue(book.BookId.Value, out int value))
                    {
                        bookOrdersQuantity[book.BookId.Value] = value + bookOrder.Quantity;
                        bookOrdersRevenue[book.BookId.Value] = value + (bookOrder.SalePrice * bookOrder.Quantity);
                    }
                    else
                    {
                        bookOrdersQuantity[book.BookId.Value] = bookOrder.Quantity;
                        bookOrdersRevenue[book.BookId.Value] = bookOrder.SalePrice * bookOrder.Quantity;
                    }
                }
            }
            var bookOrdersQuantityClone = new Dictionary<int, int>(bookOrdersQuantity);


            for (int i = 0; i < books.Count; i++)
            {
                int maxBookId = bookOrdersQuantityClone.Where(x => x.Value == bookOrdersQuantityClone.Values.Max()).Select(x => x.Key).FirstOrDefault();
                bookOrdersQuantityClone.Remove(maxBookId);

                int maxIndex = books.FindIndex(x => x.BookId == maxBookId);

                Book selected = books[i];
                books[i] = books[maxIndex];
                books[maxIndex] = selected;
            }

            for (int i = 0; i < 25 && i < books.Count(); i++)
            {
                Book book = books[i];
                int quantity = bookOrdersQuantity[book.BookId.Value];
                double revenue = bookOrdersRevenue[book.BookId.Value];

                grdBooks.Rows.Insert(i, i + 1, book.BookId, book.Title, book.Author, quantity, revenue);
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}