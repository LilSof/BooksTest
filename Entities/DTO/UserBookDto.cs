using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTO
{
    public class UserBookDto
    {
        public Guid Id { get; set; } // UserBook ID
        public string BookName { get; set; }
        public string Author { get; set; }
        public int NumberOfPages { get; set; }
        public double IsReadPercentage { get; set; }
        public int CurrentPage { get; set; }
        public DateTime AddedAt { get; set; }
    }
}
