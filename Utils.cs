using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;

namespace BookSYS
{
    public static class Utils
    {
        public static void SetupSearch(TextBox txtEntry, ComboBox txtOptions, Func<string, IEnumerable<IdNamePair>> searchProcedure, Action<IdNamePair> onSelected, Action<IEnumerable<IdNamePair>> onUpdate = null)
        {
            if(txtEntry == null)
                throw new ArgumentNullException(nameof(txtEntry));
            if(txtOptions == null)
                throw new ArgumentNullException (nameof(txtOptions));
            if(searchProcedure == null)
                throw new ArgumentNullException(nameof(searchProcedure));
            if(onSelected == null)
                throw new ArgumentNullException(nameof(onSelected));

            txtEntry.Validated += (s, e) =>
            {
                string entry = txtEntry.Text;

                if (String.IsNullOrEmpty(entry))
                {
                    txtOptions.Items.Clear();
                    return;
                }

                IEnumerable<IdNamePair> idNames = searchProcedure.Invoke(entry);

                txtOptions.Items.Clear();
                txtOptions.Items.AddRange(idNames.ToArray());

                onUpdate?.Invoke(idNames);
            };

            txtOptions.SelectedIndexChanged += (s, e) =>
            {
                IdNamePair result = null;

                if (txtOptions.SelectedIndex != -1)
                    result = (IdNamePair)txtOptions.SelectedItem;

                onSelected.Invoke(result);
            };
        }

        public static void PopulateOrderDataGridView(DataGridView control, List<Order> orders)
        {
            control.Rows.Clear();

            foreach(Order order in orders)
            {
                control.Rows.Add(order.OrderId, order.OrderDate, order.Total, order.Status);
            }
        }

        public static void PopulateBookOrderDataGridView(DataGridView control, List<BookOrder> bookOrders, Func<int, Book> bookLookup)
        {
            control.Rows.Clear();

            foreach(BookOrder bookOrder in bookOrders)
            {
                Book book = bookLookup(bookOrder.BookId);

                control.Rows.Add(bookOrder.OrderId, bookOrder.BookId, book.Title, book.Author, bookOrder.SalePrice, bookOrder.Quantity);
            }
        }
    }
}
