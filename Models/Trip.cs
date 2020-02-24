using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gas_Mileage_Calculator_App.Models
{
    public class Trip
    {
        public float MPG { get; set; }
        public float GasGallons { get; set; }
        public string Message { get; set; }
        public float TripMiles { get; set; }
        public float TripDistance { get; set; }

        public Trip(float _mpg, float _gasGallons, float _tripDistance)
        {
            MPG = _mpg;
            GasGallons = _gasGallons;
            TripDistance = _tripDistance;
        }
        public Trip(float _mpg, float _gasGallons, string _message, float _tripMiles)
        {
            MPG = _mpg;
            GasGallons = _gasGallons;
            Message = _message;
            TripMiles = _tripMiles;
        }
        public void CalculateMileage()
        {
            TripMiles = MPG * GasGallons;
        }

        public string GetResultMessage(float tripMiles, float tripDistance)
        {
            if (tripMiles >= tripDistance)
            {
                return "You made it";
            }
            else
            {
                return "You didn't make it";
            }
        }

    }
}
