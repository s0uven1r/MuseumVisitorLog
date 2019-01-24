using System;

namespace MuseumLog
{
    public class WeeklyReport
    {
        public string Day { get; set; }
        public int TotalVisitor { get; set; }
        public double TotalTimeSpent { get; set; }//in minutes
    }
}
