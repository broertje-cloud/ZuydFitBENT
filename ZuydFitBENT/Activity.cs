class Activity
{
    public int id { private set; get; }
    public string name { private set; get; }
    public DateTime date { private set; get; }
    public string location { private set; get; }
    public Program program { private set; get; }
    public List<Trainer> trainers { private set; get; }

    public Activity(int Id, string Name, DateTime Date, string Location, Program Program)
    {
        id = Id;
        name = Name;
        date = Date;
        location = Location;
        program = Program;
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
