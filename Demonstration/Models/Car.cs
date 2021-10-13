using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demonstration.Models
{
    //A CAR OBJECT
    public class Car
    {
        public string numberPlate { get; set; }

        public Car(string numberPlate)
        {
            this.numberPlate = numberPlate;
        }
    }
}
