using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UserBook
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid UserId { get; set; }
        public DateTime AddedAt { get; set; }
        public double IsReadPercentage { get; set; }
        public int CurrentPage { get; set; }

        // Navigation properties
        public Book Book { get; set; }
        public ICollection<UserBookPlan> ReadingGoals { get; set; }
    }
}
