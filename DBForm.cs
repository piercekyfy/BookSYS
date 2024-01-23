using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookSYS
{
    public abstract class DBForm : Form
    {
        protected IDBContext db;

        public void RegisterDBContext( IDBContext db )
        {
            this.db = db;
        }

        protected virtual void Initialize() { }
    }
}
