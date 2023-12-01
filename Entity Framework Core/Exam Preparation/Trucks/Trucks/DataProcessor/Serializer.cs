namespace Trucks.DataProcessor
{
    using Data;
    using Invoices.Extensions;
    using Newtonsoft.Json;
    using Trucks.Data.Models.Enums;
    using Trucks.DataProcessor.ExportDto;

    public class Serializer
    {
        public static string ExportDespatchersWithTheirTrucks(TrucksContext context)
        {
            var despatchersDto = context.Despatchers
            .Where(d => d.Trucks.Any())
            .Select(d => new ExportDespatcherDto()
            {
                TrucksCount = d.Trucks.Count(),
                Name = d.Name,
                Trucks = d.Trucks
                .Select(t => new ExportTruckDto()
                {
                    RegistrationNumber = t.RegistrationNumber,
                    Make = t.MakeType.ToString()
                })
                .OrderBy(t => t.RegistrationNumber)
                .ToArray()
            })
            .OrderByDescending(d => d.TrucksCount)
            .ThenBy(d => d.Name)
            .ToArray();

            return despatchersDto.SerializeToXml<ExportDespatcherDto[]>("Despatchers");
        }

        public static string ExportClientsWithMostTrucks(TrucksContext context, int capacity)
        {
            var clients = context.Clients
                 .Where(c => c.ClientsTrucks.Any(ct => ct.Truck.TankCapacity >= capacity))
                 .ToArray()
                 .Select(c => new
                 {
                     c.Name,
                     Trucks = c.ClientsTrucks
                     .Where(ct => ct.Truck.TankCapacity >= capacity)
                     .Select(t => new
                     {
                         TruckRegistrationNumber = t.Truck.RegistrationNumber,
                         t.Truck.VinNumber,
                         t.Truck.TankCapacity,
                         t.Truck.CargoCapacity,
                         CategoryType = t.Truck.CategoryType.ToString(),
                         MakeType = t.Truck.MakeType.ToString()
                     })
                     .OrderBy(t => t.MakeType)
                     .ThenByDescending(t => t.CargoCapacity)
                     .ToArray()

                 })
                 .OrderByDescending(c => c.Trucks.Length)
                 .ThenBy(c => c.Name)
                 .Take(10)
                 .ToArray();

            return JsonConvert.SerializeObject(clients, Formatting.Indented);
        }
    }
}
