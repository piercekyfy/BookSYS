using System;
using System.Collections.Generic;
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
    }
}
