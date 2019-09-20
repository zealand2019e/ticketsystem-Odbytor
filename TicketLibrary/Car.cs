using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
    /// <summary>
    /// A class of car.
    /// </summary>
    public class Car: Vehicle
    {
        public override string Licenseplate { get => base.Licenseplate; set => base.Licenseplate = value; }
        public override DateTime Date { get; set; }
        /// <summary>
        /// If it is sunday and customer has BroBiz then both discount are applied.
        /// </summary>
        /// <param name="BroBiz"></param>
        /// <returns></returns>
        public override double Price(bool BroBiz)
        {
            if(Date.DayOfWeek.Equals(DayOfWeek.Saturday) || Date.DayOfWeek.Equals(DayOfWeek.Sunday))//date of the vehicle entering the place instead of datetime now
            {
                if (BroBiz == true)
                {
                    return 240 * 0.8 * 0.95;
                }
                else
                    return 240 * 0.8;    
            }
                else if(BroBiz == true)
                {
                return 240 * 0.95;
                }
                else
                return 240;
        }

        public override string VehicleType()
        {
            return "Car";
        }
    }
}
