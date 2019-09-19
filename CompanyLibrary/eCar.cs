using System;
using System.Collections.Generic;
using System.Text;
using TicketLibrary;

namespace CompanyLibrary
{
   public class eCar : Vehicle
    {
        public override DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double Price(bool BroBiz)
        {
            if(BroBiz == true)
            {
                return 161;
            }
            else
            return 410;
        }

        public override string VehicleType()
        {
            return "Oresund Car";
        }
    }
}
