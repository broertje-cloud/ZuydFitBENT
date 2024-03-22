public class Trainer
{
    public int trainerId { get; private set; }
    public string name { get; private set; }
    public string emailAdress { get; private set; }
    public List<Training> trainings { get; private set; }

    public Trainer(int TrainerId, string Name, string EmailAdress)
    {
      trainerId = TrainerId;
      name = Name;
      emailAdress = EmailAdress;
      trainings = new List<Training>();
    }
    public void AddTraining(Training training)
    {
        trainings.Add(training);
    }
    public void RemoveTraining(Training training) 
    {  
        trainings.Remove(training); 
    }
}
