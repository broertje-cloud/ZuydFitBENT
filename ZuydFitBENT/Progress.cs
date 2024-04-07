using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuydFitBENT
{
    public class Progress
    {
        public DateTime Date { get; set; }
        public int Percentage { get; set; }

        public Progress(DateTime date, int percentage)
        {
            Date = date;
            Percentage = percentage;
        }
    }
}
