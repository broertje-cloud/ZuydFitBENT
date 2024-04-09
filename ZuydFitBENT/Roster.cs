class Roster
{
    public int id { private set; get; }
    public string name { private set; get; }
    public DateTime date { private set; get; }
    public string location { private set; get; }
    public List<Activity> activities { private set; get; }
    public List<RosterParticipant> participants { private set; get; }

    public Roster(int Id, string Name, DateTime Date, string Location)
    {
        id = Id;
        name = Name;
        date = Date;
        location = Location;
        activities = new List<Activity>();
        participants = new List<RosterParticipant>();
    }
    public void AddActivity(Activity activity)
    {
        activities.Add(activity);
    }
    public void RemoveActivity(Activity activity)
    {
        activities.Remove(activity);
    }
    public void AddParticipant(RosterParticipant participant)
    {
        participants.Add(participant);
    }
    public void RemoveParticipant(RosterParticipant participant)
    {
        participants.Remove(participant);
    }
}
