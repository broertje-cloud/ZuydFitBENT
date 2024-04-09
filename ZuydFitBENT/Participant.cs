class Participant
{
    public int id { private get; set; }
    public string name { private get; set; }
    public string gender { private get; set; }
    public string email { private get; set; }
    public string phone { private get; set; }
    public List<RosterParticipant> rosterParticipants { private get; set; }

    public Participant(int Id, string Name, string Gender, string Email, string Phone)
    {
        id = Id;
        name = Name;
        gender = Gender;
        email = Email;
        phone = Phone;
        rosterParticipants = new List<RosterParticipant>();
    }
}
