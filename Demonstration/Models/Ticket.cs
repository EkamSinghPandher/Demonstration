using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demonstration.Models
{
    public class Ticket
    {
        public string ticketId { get; set; }
        public string numberPlate { get; set; }
        public DateTime timeIn { get; set; }
        private string _chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

        //generate method to create a unique 8 digit string 
        //IGNORE THIS NOT RELEVANT TO HOMEWORK
        public string generateId()
        {
            char[] stringChars = new char[8];
            var random = new Random();

            for (int i = 0; i < stringChars.Length; i++)
            {
                stringChars[i] = _chars[random.Next(_chars.Length)];
            }
            return new String(stringChars);
        }


        //Constructor that takes in a cars numberplate and creates a ticket.
        //Also autogenerates a random ticket id of 8 characters to identify a ticket.
        public Ticket(Car car)
        {
            this.ticketId = generateId();
            this.numberPlate = car.numberPlate;
            this.timeIn = DateTime.Now;
        }
    }
}
