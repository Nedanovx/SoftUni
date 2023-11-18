using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Globalization;

namespace CarDealer
{
    public class StartUp
    {
        private static IMapper mapper = new Mapper(new MapperConfiguration(cfg =>
        {
            cfg.AddProfile<CarDealerProfile>();
        }));
        public static void Main()
        {
            CarDealerContext db = new CarDealerContext();

            //string input = File.ReadAllText("../../../Datasets/suppliers.json");
            //Console.WriteLine(ImportSuppliers(db, input));

            //string input = File.ReadAllText("../../../Datasets/parts.json");
            //Console.WriteLine(ImportParts(db, input));

            //string input = File.ReadAllText("../../../Datasets/cars.json");
            //Console.WriteLine(ImportCars(db, input));

            //string input = File.ReadAllText("../../../Datasets/customers.json");
            //Console.WriteLine(ImportCustomers(db, input));

            //string input = File.ReadAllText("../../../Datasets/sales.json");
            //Console.WriteLine(ImportSales(db, input));

            //Console.WriteLine(GetOrderedCustomers(db));

            //Console.WriteLine(GetCarsFromMakeToyota(db));

            //Console.WriteLine(GetLocalSuppliers(db));

            //Console.WriteLine(GetCarsWithTheirListOfParts(db));

            //Console.WriteLine(GetTotalSalesByCustomer(db));

            Console.WriteLine(GetSalesWithAppliedDiscount(db));


        }
        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {

            SupplierDTO[] supplierDTOs = JsonConvert.DeserializeObject<SupplierDTO[]>(inputJson);

            Supplier[] suppliers = mapper.Map<Supplier[]>(supplierDTOs);

            context.Suppliers.AddRange(suppliers);

            context.SaveChanges();

            return $"Successfully imported {suppliers.Length}.";
        }

        public static string ImportParts(CarDealerContext context, string inputJson)
        {

            PartDTO[] partsDTOs = JsonConvert.DeserializeObject<PartDTO[]>(inputJson);

            Part[] parts = mapper.Map<Part[]>(partsDTOs);

            int[] supplierId = context.Suppliers
                .Select(s => s.Id)
                .ToArray();

            Part[] partsWithValidSuppliersId = parts.Where(p => supplierId.Contains(p.SupplierId)).ToArray();

            context.Parts.AddRange(partsWithValidSuppliersId);
            context.SaveChanges();

            return $"Successfully imported {partsWithValidSuppliersId.Length}.";
        }

        public static string ImportCars(CarDealerContext context, string inputJson)
        {

            CarDTO[] carsDTOs = JsonConvert.DeserializeObject<CarDTO[]>(inputJson);

            ICollection<Car> cars = new HashSet<Car>();

            foreach (var carDto in carsDTOs)
            {
                Car currentCar = mapper.Map<Car>(carDto);

                foreach (var partId in carDto.PartsId)
                {
                    if (context.Parts.Any(p => p.Id == partId))
                    {
                        currentCar.PartsCars.Add(new PartCar
                        {
                            PartId = partId,
                        });
                    }
                }

                cars.Add(currentCar);
            }

            context.Cars.AddRange(cars);

            context.SaveChanges();

            return $"Successfully imported {cars.Count}.";

        }

        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            CustomerDTO[] customersDTOs = JsonConvert.DeserializeObject<CustomerDTO[]>(inputJson);

            Customer[] customers = mapper.Map<Customer[]>(customersDTOs);

            context.Customers.AddRange(customers);

            context.SaveChanges();

            return $"Successfully imported {customers.Length}.";
        }

        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            SaleDTO[] salesDTOs = JsonConvert.DeserializeObject<SaleDTO[]>(inputJson);

            Sale[] sales = mapper.Map<Sale[]>(salesDTOs);

            context.Sales.AddRange(sales);
            context.SaveChanges();

            return $"Successfully imported {sales.Length}.";
        }

        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var customers = context.Customers
                .OrderBy(c => c.BirthDate)
                .ThenBy(c => c.IsYoungDriver.ToString())
                .Select(c => new
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate.ToString("dd/MM/yyyy", DateTimeFormatInfo.InvariantInfo),
                    IsYoungDriver = c.IsYoungDriver
                })
                .ToArray();

            return JsonConvert.SerializeObject(customers, Formatting.Indented);
        }

        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var cars = context.Cars
                .Where(c => c.Make == "Toyota")
                .Select(c => new
                {
                    Id = c.Id,
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance
                })
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .ToArray();

            return JsonConvert.SerializeObject(cars, Formatting.Indented);
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var suppliers = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count
                })
                .ToArray();

            return JsonConvert.SerializeObject(suppliers, Formatting.Indented);
        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var result = context.Cars              
                .Select(c => new
                {
                    car = new
                    {
                        Make = c.Make,
                        Model = c.Model,
                        TraveledDistance = c.TraveledDistance
                    },

                    parts = c.PartsCars
                    .Select(cp => new
                    {
                        Name = cp.Part.Name,
                        Price = cp.Part.Price.ToString("f2")
                    })
                })
                .ToArray();

            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            var result = context.Customers               
                .Where(c => c.Sales.Any(s => s.Car != null))
                .Select(c => new
                {
                    fullName = c.Name,
                    boughtCars = c.Sales.Count(s => s.Car != null),
                    spentMoney = c.Sales.SelectMany(s => s.Car.PartsCars).Sum(pc => pc.Part.Price)
                })
                .OrderByDescending(c => c.spentMoney)
                .ThenByDescending(c => c.boughtCars)
                .ToArray();

            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var result = context.Sales
                .Select(c => new
                {
                    car = new
                    {
                        Make = c.Car.Make,
                        Model = c.Car.Model,
                        TraveledDistance = c.Car.TraveledDistance
                    },
                    customerName = c.Customer.Name,
                    discount = c.Discount.ToString("f2"),
                    price = c.Car.PartsCars.Sum(pc => pc.Part.Price).ToString("f2"),
                    priceWithDiscount = (c.Car.PartsCars.Sum(pc => pc.Part.Price) - 
                    ((c.Car.PartsCars.Sum(pc => pc.Part.Price) * c.Discount) / 100))
                    .ToString("f2")
                })
                .Take(10)
                .ToArray();

            return JsonConvert.SerializeObject(result, Formatting.Indented);
        }
    }
}