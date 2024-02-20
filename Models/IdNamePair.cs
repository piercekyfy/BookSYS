using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookSYS.Models
{
    public class IdNamePair
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public IdNamePair(int id, string name)
        {
            this.Id = id;
            this.Name = name;
        }
    }
}
