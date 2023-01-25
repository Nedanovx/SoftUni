using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Parking
{
    public class Parking
    {
        
        List<Car> cars = new List<Car>();
        public Parking(string type, int capacity)
        {
            Type = type;
            Capacity = capacity;
            cars = new List<Car>();
        }

        public string Type { get; set; }

        public int Capacity { get; set; }

       

        public void Add (Car car)
        {
            if(cars.Count < Capacity)
            {
                cars.Add(car);
            }
        }

        public bool Remove (string manufacturer, string model)
        {          
            if(cars.Any(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                Car currentCar = cars.Where(x => x.Manufacturer == manufacturer && x.Model == model).First();
                cars.Remove(currentCar);
                return true;
            }
            return false;
        }

        public Car GetLatestCar()  
        {
            if(cars.Count > 0)
            {
                return cars.OrderByDescending(x => x.Year).First();
            }
            return null;
            
        }

        public Car GetCar(string manufacturer, string model)
        {
            if (cars.Any(x => x.Manufacturer == manufacturer && x.Model == model))
            {
                Car currentCar = cars.Where(x => x.Manufacturer == manufacturer && x.Model == model).First();
                
                return currentCar;
            }
            return null;
        }

        public int Count => cars.Count; 
        public string GetStatistics()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"The cars are parked in {Type}:");
            foreach(var car in cars)
            {
                sb.AppendLine(car.ToString());
            }
            return sb.ToString();
        }
    }
}
