using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class MC: Vehicle
    {
        public override string Licenseplate { get => base.Licenseplate; set => base.Licenseplate = value; }
        public override DateTime Date { get; set; }

        public override double Price()
        {
            return 125;
        }

        public override string VehicleType()
        {
            return "MC";
        }
    }
}
