using System;
using System.Collections.Generic;
using System.Text;
using TicketLibrary;

namespace CompanyLibrary
{
   public class eMC : Vehicle
    {
        public override DateTime Date { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public override double Price(bool BroBiz)
        {
            if (BroBiz == true)
            {
                return 73;
            }
            else
            return 210;
        }

        public override string VehicleType()
        {
            return "Oresund MC";
        }
    }
}
