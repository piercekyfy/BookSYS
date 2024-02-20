﻿using BookSYS.Models;
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
    }
}
