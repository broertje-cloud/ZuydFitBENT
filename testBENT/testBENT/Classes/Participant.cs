using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testBENT.DAL;

namespace testBENT.Classes
{
    class Participant
    {
        public int id { private get; set; }
        public string name { private get; set; }
        public string gender { private get; set; }
        public string email { private get; set; }
        public string phone { private get; set; }
        public List<Goal> goals { private get; set; }

        public Participant(int Id, string Name, string Gender, string Email, string Phone)
        {
            id = Id;
            name = Name;
            gender = Gender;
            email = Email;
            phone = Phone;
            goals = new List<Goal>();
        }
        public string? Name
        {
            get { return name; }
            set { name = value; }
        }
        public void AddRosterParkingParticipant(Goal goal)
        {
            goals.Add(goal);
        }
        public void RemoveRosingParticipant(Goal goal)
        {
            goals.Remove(goal);
        }
    }
}
