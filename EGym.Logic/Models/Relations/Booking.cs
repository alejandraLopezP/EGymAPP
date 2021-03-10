using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EGym.Logic.Models.Relations
{
    public class Booking
    {
        public int TrainerId { get; internal set; }
        //ClientID
        public int ClientId { get; set; }
        public int ActivityId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public bool trainer = false;
        //TODO: Individuall training without  PT ctor

        public Booking()
        {

        }
        //TODO:Group training ctor
        public Booking()
        {

        }

        //TODO : 
        public void WithTrainer(bool trainer)
        {
            this.trainer = trainer;

        }
    }
}
