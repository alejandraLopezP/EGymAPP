using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGym.Logic.Models.People
{
    public class Client
    {
        public string name { get; set; }
        public string eMail { get; set; }
        public string id { get; set; }
        public string phoneNumber { get; set; }

        //New Client
        public Client(string name, string eMail, string phoneNumber)
        {
            this.eMail = eMail;
            this.phoneNumber = phoneNumber;
            this.name = name;
        }
        //Existing  Client
        public Client(string id)
        {
            this.id = id;

        }

    }
}
