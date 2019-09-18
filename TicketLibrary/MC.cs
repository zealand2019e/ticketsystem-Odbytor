using System;
using System.Collections.Generic;
using System.Text;

namespace TicketLibrary
{
   public class MC
    {
        public string Licensplate { get; set; }
        public DateTime date { get; set; }

        public double Price()
        {
            return 125;
        }

        public string Vehicle()
        {
            return "MC";
        }
    }
}
