using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class MC: Vehicle
    {
        public override string Licenseplate { get => base.Licenseplate; set => base.Licenseplate = value; }
        public override DateTime Date { get; set; }
        /// <summary>
        /// If BroBiz is true then discount is being applied.
        /// </summary>
        /// <param name="BroBiz"></param>
        /// <returns></returns>
        public override double Price(bool BroBiz)
        {
            if(BroBiz == true)
            {
                return 125 * 0.95;
            }
            else
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
