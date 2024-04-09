class Goal
{
    public int id { private set; get; }
    public string description { private set; get; }
    public List<Progress> progress { private set; get; }
    public RosterParticipant rosterParticipant { private set; get; }

    public Goal(int Id, string Description, RosterParticipant RosterParticipant)
    {
        id = Id;
        description = Description;
        progress = new List<Progress>();
        rosterParticipant = RosterParticipant;
    }
    public void AddProgress(Progress Progress)
    {
        progress.Add(Progress);
    }
    public void RemoveProgress(Progress Progress)
    {
        progress.Remove(Progress);
    }
}
