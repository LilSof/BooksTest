using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class UserBookPlan
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid UserBookId { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public int PagesGoal { get; set; }

        // Navigation property
        public UserBook UserBook { get; set; }
    }
}
