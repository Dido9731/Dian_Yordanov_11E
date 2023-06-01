using System;
using BusinessLayer;
using DataLayer;

namespace TestingLayer
{
    class Program
    {
        static void Main(string[] args)
        {
            Flight polet = new Flight(1, "Turkey");
            Airport letishte = new Airport(1, "Dian");

            FlightsContext flightsContext = new FlightsContext(new FlightsDbContext());
            AirportContext airportContext = new AirportContext(new FlightsDbContext());

            flightsContext.Create(polet);
            airportContext.Create(letishte);
        }
    }
}
