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
    class Airline
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public Dictionary<string, Flight> Flights { get; set; } = new Dictionary<string, Flight>();

        public Airline()
        {

        }

        public Airline(string name, string code)
        {
            Name = name;
            Code = code;
        }

        public bool AddFlight(Flight flight)
        {
            if(Flights.ContainsKey(flight.FlightNumber))
            {
                return false;
            }
            Flights.Add(flight.FlightNumber, flight);
            return true;
        }

        public double CalculateFees()
        {
            double fees = 0.0;
            double discountGiven = 0.0;

            int numberOfFlights = Flights.Values.Count;
            int numberOfDiscount = numberOfFlights / 3;
            discountGiven = 350 * numberOfDiscount;

            foreach (var flight in Flights.Values)
            {
                fees += flight.CalculateFees();
            }
            if (numberOfFlights > 5)
            {
                discountGiven += fees * 0.03;
            }
        }
    }
}
