using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuydFitBENT
{
    public class Activity
    {
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public string Name { get; set; }

        public Activity(DateTime date, string location, string name)
        {
            Date = date;
            Location = location;
            Name = name;
        }
    }
}
