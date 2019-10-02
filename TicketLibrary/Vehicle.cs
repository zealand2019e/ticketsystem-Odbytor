using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    public abstract class Vehicle
    {
        

        string _licensplate;
        /// <summary>
        /// Setter checks if length of Licensplate number is not more then 7.
        /// </summary>
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
        public abstract double Price(bool BroBiz);
        /// <summary>
        /// Return a type of a car.
        /// </summary>
        /// <returns></returns>
        public abstract string VehicleType();
        
        

    }
}
