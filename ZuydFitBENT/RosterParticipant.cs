class Trainer
{
    public int id { private set; get; }
    public string name { private set; get; }
    public string expertise { private set; get; }
    public string email { private set; get; }
    public string phoneNumber { private set; get; }
    public List<Activity> activities { private set; get; }

    public Trainer(int Id, string Name, string Expertise, string Email, string PhoneNumber)
    {
        id = Id;
        name = Name;
        expertise = Expertise;
        email = Email;
        phoneNumber = PhoneNumber;
        activities = new List<Activity>();
    }
    public void AddActivity(Activity activity)
    {
        activities.Add(activity);
    }
    public void RemoveActivity(Activity activity) 
    {
        activities.Remove(activity);
    }
}
