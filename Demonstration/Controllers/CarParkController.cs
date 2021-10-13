using Demonstration.Models;
using Demonstration.Services.CarParkService;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Demonstration.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarParkController : ControllerBase
    {
        private readonly ICarParkService _carParkService;

        public CarParkController(ICarParkService carParkService)
        {
            this._carParkService = carParkService;
        }

        //TO CREATE A API ENDPOINT, SPECIFY THE TYPE OF ENDPOINT, EG GET, POST.
        //ONCE DONE YOUR CONTROLLER SHOULD CALL THE SERVICE AND LET THE SERVICE HANDLE THE LOGIC
        //CHECK FOR A ERROR MESSAGE IN THE SERVICE RESPONSE, IF THERE IS A ERROR, RETURN THE APPROPRIATE ERROR CODE
        [HttpGet]
        async public Task<IActionResult> checkAvailablity()
        {
            //REMEMBER THE AWAIT SINCE WE ARE USING ASYNCHRONOUS CODE SO YOU NEED TO WAIT FOR A RESULT
            ServiceResponse<int> availability = await _carParkService.CheckAvailability();
            if(availability.Data == null)
            {
                //BAD REQUEST IS 400 AND IS WHEN WE HAVE A ERROR
                return BadRequest(availability.Message);
            }
            else
            {
                //OK RETURNS A 200 MESSAGE AND RETURNS THE DATA FROM THE SERVICE
                return Ok(availability.Data);
            }
        }

        [HttpPost]
        async public Task<IActionResult> parkCar(Car car)
        {
            //IMPLEMENT HOW YOU HANDLE THE DATA HERE (FOLLOW THE TOP EXAMPLE AND MAKE SURE YOU USE THE CORRECT REQUEST TYPE)
            return null;
        }

        //IMPLEMENT THE LAST API ENDPOINT (UNPARK CAR)
    }
}
