using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS
{
    public static class Utils
    {
        public static bool ValidateFilled(List<TextBox> textBoxes, out TextBox firstEmpty)
        {
            firstEmpty = null;
            foreach (var textBox in textBoxes)
            {
                if (String.IsNullOrEmpty(textBox.Text))
                {
                    firstEmpty = textBox;
                    return false;
                }
            }
            return true;
        }

        public static void SetupBookSearch(TextBox txtTitle, ComboBox cboOptions, Func<string, IEnumerable<Book>> searchProcedure, Action<Book> onSelected, Action<IEnumerable<Book>> onUpdate = null)
        {
            if(txtTitle == null)
                throw new ArgumentNullException(nameof(txtTitle));
            if(cboOptions == null)
                throw new ArgumentNullException (nameof(cboOptions));
            if(searchProcedure == null)
                throw new ArgumentNullException(nameof(searchProcedure));
            if(onSelected == null)
                throw new ArgumentNullException(nameof(onSelected));

            txtTitle.Validated += (s, e) =>
            {
                string title = txtTitle.Text;

                if (String.IsNullOrEmpty(title))
                {
                    cboOptions.Items.Clear();
                    return;
                }

                IEnumerable<Book> books = searchProcedure.Invoke(title);

                cboOptions.Items.Clear();
                cboOptions.Items.AddRange(books.ToArray());

                onUpdate?.Invoke(books);
            };

            cboOptions.SelectedIndexChanged += (s, e) =>
            {
                Book book = null;

                if (cboOptions.SelectedIndex != -1)
                    book = (Book)cboOptions.SelectedItem;

                onSelected.Invoke(book);
            };
        }
    }
}
