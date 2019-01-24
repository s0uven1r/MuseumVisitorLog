using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MuseumLog
{
    public class VisitorInfo
    {

        [CsvIgnore]
        public string Day { get; set; }
        public Int64 ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public Int64 ContactNo { get; set; }
        public string MailAddress { get; set; }
        public string Occupation { get; set; }
        public string EntryDate { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        [CsvIgnore]
        public double TotalTime { get; set; } //in minutes
    }
}
