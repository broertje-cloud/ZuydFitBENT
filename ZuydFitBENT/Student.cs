internal class Student
{
    public string name { get; private set; }
    public int studentNumber { get; private set; }
    public List<Goal> goals { get; private set; }
    public string emailAdress { get; private set; }
  
    public Student(string Name, int StudentNumber, string EmailAdress)
    {
        name = Name;
        studentNumber = StudentNumber;
        goals = new List<Goal>();
        emailAdress = EmailAdress;
    }
    public void AddGoal(Goal goal)
    {
        goals.Add(goal);
    }
    public void RemoveGoal(Goal goal) 
    {  
        players.Remove(goal); 
    }
    public void DisplayCurrentGoals(Student student)
    {
        Console.WriteLine("The student's current goals are:");
        foreach(Goal goal in goals)
        {
          if(goals.achieved == false)
          {
            Console.WriteLine(Goal.description);
          }
        }
    }
