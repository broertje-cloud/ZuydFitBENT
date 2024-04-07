using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZuydFitBENT
{
    public class Trainer
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Expertise { get; set; }

        public Trainer(string name, string emailAddress, string phoneNumber, string expertise)
        {
            Name = name;
            EmailAddress = emailAddress;
            PhoneNumber = phoneNumber;
            Expertise = expertise;
        }
    }

}
