using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS
{
    // The Windows Form designer doesn't play well if the first level of inheritance for a form is abstract (because Form itself is abstract).
    // In order to fix this, when debugging DbForm is the child of a dummy class that inherits from Form but this is removed in Release builds.
    // Explained by: https://stackoverflow.com/a/2406754
#if DEBUG
    public class DesignerInheritanceForm : Form { }
#endif

    public class DBForm : 
#if DEBUG 
        DesignerInheritanceForm
#else
        Form
#endif
    {
        protected IDBContext db;

        public void RegisterDBContext( IDBContext db )
        {
            this.db = db;
        }

        protected virtual void Initialize() { }
    }
}
