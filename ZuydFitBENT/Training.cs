public class Training
{
    public DateTime date { get; private set; }
    public string name { get; private set; }
    public string location { get; private set; }
    public List<Trainer> trainers { get; private set; }
  
    public Training(DateTime Date, string Name, string Location)
    {
        date = Date;
        name = Name;
        location = Location;
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
