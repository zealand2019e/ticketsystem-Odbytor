using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public abstract class Vehicle
    {
        string _licensplate;
        public virtual string Licenseplate
        {
            get { return _licensplate; }
            set
            {
                if (value.Length > 7)
                {
                    throw new ArgumentOutOfRangeException("You need to enter Licensplate with maximum 7 numbers.");
                }
                else
                    _licensplate = value;
            }
        }
        public abstract DateTime Date { get; set; }

        /// <summary>
        /// Returns a price of a car.
        /// </summary>
        /// <returns></returns>
        public abstract double Price();
        /// <summary>
        /// Return a type of a car.
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
        
        

    }
}
