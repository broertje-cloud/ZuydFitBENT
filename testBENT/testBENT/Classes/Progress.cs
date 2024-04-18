using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testBENT.DAL;

namespace testBENT.Classes
{
    internal class Progress
    {
        public int id { private set; get; }
        public DateTime date { private set; get; }
        public int percentage { private set; get; }

        public Progress(int Id, DateTime Date, int Percantage)
        {
            id = Id;
            date = Date;
            percentage = Percantage;
        }
    }
}
