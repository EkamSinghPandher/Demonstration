using Demonstration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demonstration.Services.CarParkService
{
    public class CarParkService : ICarParkService
    {
        public int MAX_CAPACITY { get; set; }
        public string PEAK_HOUR_START = "18:00";
        public string PEAK_HOUR_END = "00:00";
        public double OFF_PEAK_PRICE_PER_SECOND = 0.0001;
        public double PEAK_PRICE_PER_SECOND = 0.00025;
        //THE 'DATABASE' IS A LIST OF CARS, WHEN A CAR IS PARKED, ADD IT TO THE LIST, WHEN UNPARKED, REMOVE IT. 
        //MAKE SURE THE CARPARK DOES NOT EXCEED THE MAX CAPACITY
        public List<Car> DATABASE = new List<Car>();
        public Task<ServiceResponse<int>> CheckAvailability()
        {
            //REMOVE THE EXCEPTION AND WRTIE YOUR CODE HERE
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<Ticket>> ParkCar(Car carToPark)
        {
            //REMOVE THE EXCEPTION AND WRTIE YOUR CODE HERE
            throw new NotImplementedException();
        }

        public Task<ServiceResponse<int>> unparkCar(Ticket unparkTicket)
        {
            throw new NotImplementedException();
        }
    }
}
