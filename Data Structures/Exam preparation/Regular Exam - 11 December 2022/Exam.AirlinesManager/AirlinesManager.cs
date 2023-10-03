using System;
using System.Collections.Generic;
using System.Linq;

namespace Exam.DeliveriesManager
{
    public class AirlinesManager : IAirlinesManager
    {

        private Dictionary<string, Airline> airlinesById = new Dictionary<string, Airline>();
        private Dictionary<string, Flight> flightById = new Dictionary<string, Flight>();
        public void AddAirline(Airline airline)
        {
            airlinesById.Add(airline.Id, airline);
        }

        public void AddFlight(Airline airline, Flight flight)
        {
            if (!airlinesById.ContainsKey(airline.Id))
            {
                throw new ArgumentException();
            }
            airlinesById[airline.Id].Flights.Add(flight);
            flightById.Add(flight.Id, flight);
        }

        public bool Contains(Airline airline)
        {
            return airlinesById.ContainsKey(airline.Id);
        }

        public bool Contains(Flight flight)
        {
            return flightById.ContainsKey(flight.Id);
        }

        public void DeleteAirline(Airline airline)
        {
            if (!airlinesById.ContainsKey(airline.Id))
            {
                throw new ArgumentException();
            }

            foreach(var flight in flightById.Values)
            {
              flightById.Remove(flight.Id);
            }

            airlinesById.Remove(airline.Id);


        }

        public IEnumerable<Airline> GetAirlinesOrderedByRatingThenByCountOfFlightsThenByName()
        {
            return airlinesById.Select(a => a.Value).OrderByDescending(x => x.Rating).ThenByDescending(a => a.Flights.Count).ThenBy(a => a.Name);
        }

        public IEnumerable<Airline> GetAirlinesWithFlightsFromOriginToDestination(string origin, string destination)
        {
            return airlinesById.Select(a => a.Value).Where(x => x.Flights.Any(f => f.Destination == destination && f.Origin == origin && f.IsCompleted == false));
        }

        public IEnumerable<Flight> GetAllFlights()
        {
            return flightById.Values;
        }

        public IEnumerable<Flight> GetCompletedFlights()
        {
            return flightById.Values.Where(x => x.IsCompleted);
        }

        public IEnumerable<Flight> GetFlightsOrderedByCompletionThenByNumber()
        {
            return flightById.Values.OrderBy(x => x.IsCompleted).ThenBy(x => x.Number);
        }

        public Flight PerformFlight(Airline airline, Flight flight)
        {
            if (!flightById.ContainsKey(flight.Id) || !airlinesById.ContainsKey(airline.Id))
            {
                throw new ArgumentException();
            }
            flightById[flight.Id].IsCompleted = true;
            return flightById[flight.Id];
        }
    }
}
