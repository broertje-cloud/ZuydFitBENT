using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using testBENT.DAL;

namespace testBENT.Classes
{
    class Roster
    {
        public int id { private set; get; }
        public string name { private set; get; }
        public string location { private set; get; }
        public List<Activity> activities { private set; get; }
        public List <Goal> goals { private set; get; }

        public Roster(int Id, string Name, string Location)
        {
            id = Id;
            name = Name;
            location = Location;
            activities = new List<Activity>();
            goals = new List<Goal>();
        }
        public void AddActivity(Activity activity)
        {
            activities.Add(activity);
        }
        public void RemoveActivity(Activity activity)
        {
            activities.Remove(activity);
        }
        public void AddGoal(Goal goal)
        {
            goals.Add(goal);
        }
        public void RemoveGoal(Goal goal)
        {
            goals.Remove(goal);
        }
    }
}
