using testBENT.Classes;

namespace testBENT
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Initialise Roster
            Roster roster = new Roster(1, "Rooster1", "Sportschool Zuyd");
            bool loop = true;
            while (loop)
            {
                // Menu options
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Add Participant");
                Console.WriteLine("2. Add Activity & Trainer");
                Console.WriteLine("3. Add Goal");
                Console.WriteLine("4. Sign up for Activity");
                Console.WriteLine("5. Add Trainer to Activity");
                Console.WriteLine("6. Add Activity to Trainer");
                Console.WriteLine("7. Check Activities");
                Console.WriteLine("8. Check Goals");
                Console.WriteLine("9. Exit");

                string choice = Console.ReadLine();
                //Add Participant, I'll add exceptions later for int
                if (choice == "1")
                {
                    Console.WriteLine("Enter participant's Id:");
                    int participantId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter participant's Name:");
                    string participantName = Console.ReadLine();
                    Console.WriteLine("Enter participant's Gender:");
                    string participantGender = Console.ReadLine();
                    Console.WriteLine("Enter participant's Email:");
                    string participantEmail = Console.ReadLine();
                    Console.WriteLine("Enter participant's Phonenumber:");
                    string participantPhone = Console.ReadLine();
                    Participant newParticpant = new Participant(participantId, participantName, participantGender, participantEmail, participantPhone);
                    //Code om newParticipant naar database te sturen
                }
                //Add Activity & Trainer, exceptions highly needed
                else if (choice == "2")
                {
                    Console.WriteLine("Enter activity's Id:");
                    int activityId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter activity's Name:");
                    string activityName = Console.ReadLine();
                    Console.WriteLine("Enter activity's Location:");
                    string activityLocation = Console.ReadLine();
                    Console.WriteLine("Enter activity's Date:");
                    DateTime activityDate = Convert.ToDateTime(Console.ReadLine());  //Later ZEKER exception toevoegen
                    Console.WriteLine("Enter trainer's Id");
                    int trainerId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter trainer's Name");
                    string trainerName = Console.ReadLine();
                    Console.WriteLine("Enter trainer's Expertise");
                    string trainerExpertise = Console.ReadLine();
                    Console.WriteLine("Enter trainer's Email");
                    string trainerEmail = Console.ReadLine();
                    Console.WriteLine("Enter trainer's Phonenumber");
                    string trainerPhone = Console.ReadLine();
                    Activity newActivity = new Activity(activityId, activityName, activityDate, activityLocation, roster);
                    Trainer newTrainer = new Trainer(trainerId, trainerName, trainerExpertise, trainerEmail, trainerPhone);
                    newActivity.AddTrainer(newTrainer);
                    newTrainer.AddActivity(newActivity);
                    roster.AddActivity(newActivity);
                    //Send it all to Database
                }
                //Add Goal, exception toevoegen voor geen participants
                else if (choice == "3")
                {
                    Console.WriteLine("Enter goal's Id");
                    int goalId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter goal's description");
                    string goalDescription = Console.ReadLine();
                    Console.WriteLine("Do you want to add progress to the goal? Y/N");
                    //Progress aanmaken toevoegen
                    //Hier participants ophalen via de database en aan list toevoegen zodat je uit deze kan kiezen
                    List<Participant> participants = new List<Participant>();
                    Console.WriteLine("Which participant do you pick?:");
                    if (participants.Count == 0)
                    {
                        Console.WriteLine("No participants exist. Please add a participant first.");
                    }
                    else
                    {
                        Console.WriteLine("Select a participant to add a goal:");
                        for (int i = 0; i < participants.Count; i++)
                        {
                            Console.WriteLine($"{i + 1}. {participants[i].Name}");
                        }

                        int Index;
                        while (true)
                        {
                            // Check for valid inpuit against index
                            if (int.TryParse(Console.ReadLine(), out Index) && Index > 0 && Index <= participants.Count)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input. Please enter a valid owner number.");
                            }
                        }
                    }
                }
                //Signing a participant up for an activity
                else if (choice == "4")
                {
                    //Exception om te kijken of er participants zijn
                    //Haal lijst van activities en bepaalde Participant op via database?
                    //Add Goal to Roster???
                }
                //Add Trainer to activity
                else if (choice == "5")
                {
                    //Haal alle trainers op via de database hier
                }
            }
        }
    }
}
