using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Book
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }

        // Navigation property
        public ICollection<UserBook> UserBooks { get; set; }
    }
}
