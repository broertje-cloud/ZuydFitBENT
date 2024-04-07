using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuydFitBENT
{
    public class Participant
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }

        public Participant(string name, string emailAddress, string gender, string phoneNumber)
        {
            Name = name;
            EmailAddress = emailAddress;
            Gender = gender;
            PhoneNumber = phoneNumber;
        }
    }

}
