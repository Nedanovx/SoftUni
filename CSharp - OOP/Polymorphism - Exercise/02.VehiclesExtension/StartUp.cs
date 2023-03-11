﻿using VehiclesExtension.Core;
using VehiclesExtension.Core.Interfaces;
using VehiclesExtension.Factories;
using VehiclesExtension.Factories.Interfaces;
using VehiclesExtension.IO;
using VehiclesExtension.IO.Interfaces;

namespace VehiclesExtension
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IVehicleFactory factory = new VehicleFactory();
            IEngine engine = new Engine(reader, writer, factory);
            engine.Run();
        }
    }
}