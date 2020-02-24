using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gas_Mileage_Calculator_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Gas_Mileage_Calculator_App.Controllers
{
    public class RangeController : Controller
    {
        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Result(float mpg, float gasGallons, float tripDistance)
        {
            Trip trip = new Trip(mpg, gasGallons, tripDistance);
            trip.CalculateMileage();
            
            if(trip.TripMiles >= tripDistance)
            {
                trip.Message = "You made it!";
            }
            else
            {
                trip.Message = "You didn't make the trip.";
            }

            return View(trip);
        }
    }
}

