using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using testBENT.DAL; 

namespace testBENT.Classes
{
    class Activity
    {
        public int id { private set; get; }
        public string name { private set; get; }
        public DateTime date { private set; get; }
        public string location { private set; get; }
        public Roster roster { private set; get; }
        public List<Trainer> trainers { private set; get; }


        public Activity(int Id, string Name, DateTime Date, string Location, Roster Roster)
        {
            id = Id;
            name = Name;
            date = Date;
            location = Location;
            roster = Roster;
            trainers = new List<Trainer>();
        }
        public void AddTrainer(Trainer trainer)
        {
            trainers.Add(trainer);
        }
        public void RemoveTrainer(Trainer trainer) 
        {  
            trainers.Remove(trainer); 
        }
    }
}
