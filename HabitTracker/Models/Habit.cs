using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HabitTracker.Models
{
    public class Habit
    {
        public int HabitId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Frequency { get; set; }
        public DateTime? LastCompletedDate { get; set; }
        public int Streak { get; set; }
    }

}
