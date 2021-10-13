using Demonstration.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demonstration.Services.CarParkService
{
    //TODO, IMPLEMENT THE METHODS SPECIFIED BY THIS INTERFACE
    public interface ICarParkService
    {
        //CHECK FOR WETHER THE CARPARK HAS ANY SLOTS IF IT DOES, RETURN THE MNUMBER OF SLOTS, ELSE RETURN A ERROR MESSAGE
        public Task<ServiceResponse<int>> CheckAvailability();
        //PARK THE CAR BY ADDING IT TO THE 'DATABASE', ONCE ADDED IT SHOULD GENERATE A TICKET AND RETURN THE TICKET TO THE USER. iF THERE ARE
        //NO MORE SLOTS, THEN THERE SHOULD BE A ERROR MESSAGE RETURNED
        public Task<ServiceResponse<Ticket>> ParkCar(Car carToPark);
        //UNPARK THE CAR BY REMOVING IT FROM THE 'DATABASE', USE THE TICKET TO CHECK FOR THE FEES THAT THE DRIVER NEEDS TO PAY AND RETURN THE
        //FEES AMOUNT
        public Task<ServiceResponse<int>> unparkCar(Ticket unparkTicket);
    }
}
