using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    /// <summary>
    /// A class of car.
    /// </summary>
    public class Car
    {
        public string Licenseplate { get; set; }
        public DateTime Date { get; set; }

        /// <summary>
        /// Returns a price of a car.
        /// </summary>
        /// <returns></returns>
        public double Price()
        {
            return 240;
        }

        /// <summary>
        /// Return a type of a car.
        /// </summary>
        /// <returns></returns>
        public string VehicleType()
        {
            return "Car";
        }
    }
}
