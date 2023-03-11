using Vehicles.Core.Interfaces;
using Vehicles.Factories.Interfaces;
using Vehicles.IO.Interfaces;
using Vehicles.Models.Interfaces;

namespace Vehicles.Core
{
    public class Engine : IEngine
    {
        private IReader reader;
        private IWriter writer;
        private IVehicleFactory vehicleFactory;

        private readonly ICollection<IVehicle> vehicles;
        public Engine(IReader reader, IWriter writer, IVehicleFactory vehicleFactory)
        {
            this.reader = reader;
            this.writer = writer;
            this.vehicleFactory = vehicleFactory;

            vehicles = new List<IVehicle>();
        }

        public void Run()
        {
           vehicles.Add(CreatVehicle());
           vehicles.Add(CreatVehicle());
           int commandsCount = int.Parse(reader.ReadLine());

            for(int i = 0; i < commandsCount; i++)
            {
                try
                {
                    ProcessCommand();
                }
                catch(ArgumentException ex)
                {
                    writer.WriteLine(ex.Message);
                }
            }
            foreach(IVehicle vehicle in vehicles)
            {
                writer.WriteLine(vehicle.ToString());
            }
        }

        private void ProcessCommand()
        {
            string[] cmdArg = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string command = cmdArg[0];
            string type = cmdArg[1];
            IVehicle vehicle = vehicles.FirstOrDefault(x => x.GetType().Name == type);

            if (vehicle == null)
            {
                throw new ArgumentException("Invalid vehicle type");
            }
            switch (command)
            {
                case "Drive":
                    double distance = double.Parse(cmdArg[2]);
                    writer.WriteLine(vehicle.Drive(distance));
                    break;
                case "Refuel":
                    double amount = double.Parse(cmdArg[2]);
                    vehicle.Refuel(amount);
                    break;
            }            
        }

        private IVehicle CreatVehicle()
        {
            string[] inputInfo = reader.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

            return vehicleFactory.Create(inputInfo[0], double.Parse(inputInfo[1]), double.Parse(inputInfo[2]));
        }
    }
}
