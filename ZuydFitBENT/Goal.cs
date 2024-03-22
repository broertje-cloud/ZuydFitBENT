internal class Goal
{
    public bool achieved { get; private set; }
    public string description { get; private set; }
    public double percentage { get; private set; }
  
    public Goal(bool Achieved, string Description, double Percentage)
    {
      achieved = Achieved;
      description = Description;
      percentage = Percentage;
    }
}
