﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//==========================================================
// Student Number : S10270502F
// Student Name : Pierre
// Partner Name : Javier
//==========================================================

namespace PRG2_ASG
{
    class LWTTFlight : Flight
    {
        public double requestFee { get; set; }
        public LWTTFlight(string FN, string Origin, string Destination, DateTime ExpectedTime, string Status, double RequestFee) : base(FN, Origin, Destination, ExpectedTime, Status)
        {
            requestFee = RequestFee;
        }

        public override string ToString()
        {
            return $" ";
        }

        public override double CalculateFees()
        {
            return 0.0;
        }
    }
}
