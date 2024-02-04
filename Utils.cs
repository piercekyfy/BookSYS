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

        public static void SetupSearch<T>(TextBox txtEntry, ComboBox txtOptions, Func<string, IEnumerable<T>> searchProcedure, Action<T> onSelected, Action<IEnumerable<T>> onUpdate = null) where T : class
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

                IEnumerable<T> books = searchProcedure.Invoke(entry);

                txtOptions.Items.Clear();
                txtOptions.Items.AddRange(books.ToArray());

                onUpdate?.Invoke(books);
            };

            txtOptions.SelectedIndexChanged += (s, e) =>
            {
                T result = null;

                if (txtOptions.SelectedIndex != -1)
                    result = (T)txtOptions.SelectedItem;

                onSelected.Invoke(result);
            };
        }
    }
}
