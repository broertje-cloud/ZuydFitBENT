using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testBENT.DAL;

namespace testBENT.Classes
{
    class Goal
    {
        public int id { private set; get; }
        public string description { private set; get; }
        public List<Progress> progress { private set; get; }
        public Roster pRoster { private set; get; }
        public Participant pParticipant { private set; get; }

        public Goal(int Id, string Description, Roster pRoster, Participant pParticipant)
        {
            id = Id;
            description = Description;
            progress = new List<Progress>();
            this.pRoster = pRoster;
            this.pParticipant = pParticipant;
        }
        public void AddProgress(Progress Progress)
        {
            progress.Add(Progress);
        }
        public void RemoveProgress(Progress Progress)
        {
            progress.Remove(Progress);
        }
    }
}
