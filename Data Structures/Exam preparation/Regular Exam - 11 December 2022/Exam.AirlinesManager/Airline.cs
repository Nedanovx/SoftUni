﻿using System.Collections.Generic;

namespace Exam.DeliveriesManager
{
    public class Airline
    {
        public Airline(string id, string name, double rating)
        {
            Id = id;
            Name = name;
            Rating = rating;
            Flights = new List<Flight>();
        }

        public string Id { get; set; }

        public string Name { get; set; }

        public double Rating { get; set; }

        public List<Flight> Flights { get; set; }
    }
}
