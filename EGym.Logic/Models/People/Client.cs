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
        private string number { get; set; }
        private string email { get; set; }
        private int customerId { get; set; }

        // Create object when register
        public Client(string Name, string Number, string Email)
        {
            this.name = Name;
            this.number = Number;
            this.email = Email;
        }
        // Add to existing Client
        public Client(int Id)
        {
            this.customerId = Id;
        }
        

    }
}
