using AutoMapper;
using AutoMapper.QueryableExtensions;
using CarDealer.Data;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;
using ProductShop.Utilities;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace CarDealer
{
    public class StartUp
    {
        private static Mapper GetMapper ()
        {
            var cfg = new MapperConfiguration(cfg => cfg.AddProfile<CarDealerProfile>());

            return new Mapper(cfg);
        }

       
        public static void Main()
        {
            CarDealerContext db = new CarDealerContext();

            //string inputSuppliers = File.ReadAllText("../../../Datasets/suppliers.xml");
            //Console.WriteLine(ImportSuppliers(db, inputSuppliers));

            //string inputParts = File.ReadAllText("../../../Datasets/parts.xml");
            //Console.WriteLine(ImportParts(db, inputParts));

            //string inputCars = File.ReadAllText("../../../Datasets/cars.xml");
            //Console.WriteLine(ImportCars(db, inputCars));

            //string inputCustomers = File.ReadAllText("../../../Datasets/customers.xml");
            //Console.WriteLine(ImportCustomers(db, inputCustomers));

            //string inputSales = File.ReadAllText("../../../Datasets/sales.xml");
            //Console.WriteLine(ImportSales(db, inputSales));

            //Console.WriteLine(GetCarsWithDistance(db));

            //Console.WriteLine(GetCarsFromMakeBmw(db));

            //Console.WriteLine(GetLocalSuppliers(db));

            //Console.WriteLine(GetCarsWithTheirListOfParts(db));

            //Console.WriteLine(GetTotalSalesByCustomer(db));

            Console.WriteLine(GetSalesWithAppliedDiscount(db));


        }

        public static string ImportSuppliers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SupplierDTO[]), new XmlRootAttribute("Suppliers"));


            using var reader = new StringReader(inputXml);

            SupplierDTO[] supplierDTOs = (SupplierDTO[])xmlSerializer.Deserialize(reader);

            var mapper = GetMapper();

            Supplier[] suppliers = mapper.Map<Supplier[]>(supplierDTOs);

            context.Suppliers.AddRange(suppliers);

            context.SaveChanges();

            return $"Successfully imported {suppliers.Length}";
        }

        public static string ImportParts(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(PartDTO[]), new XmlRootAttribute("Parts"));

            using var reader = new StringReader(inputXml);

            PartDTO[] partDTOs = (PartDTO[])xmlSerializer.Deserialize(reader);

            var suppliersId = context.Suppliers
                .Select(s => s.Id)
                .ToArray();

            var mapper = GetMapper();

            Part[] parts = mapper.Map<Part[]>(partDTOs.Where(p => suppliersId.Contains(p.SupplierId)));

            context.Parts.AddRange(parts);

            context.SaveChanges();

            return $"Successfully imported {parts.Length}";
        }

        public static string ImportCars(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CarDTO[]), new XmlRootAttribute("Cars"));

            using var reader = new StringReader(inputXml);

            CarDTO[] carDTOs = (CarDTO[])xmlSerializer.Deserialize(reader);

            var mapper = GetMapper();

            List<Car> cars = new List<Car>();

            foreach(var carDTO in carDTOs)
            {
                Car car = mapper.Map<Car>(carDTO);

                int[] carPartsIds = carDTO.PartsIds.Select(p => p.Id).Distinct().ToArray();
                    
                var carParts = new List<PartCar>();

                foreach(var id in carPartsIds)
                {
                    carParts.Add(new PartCar
                    {
                        Car = car,
                        PartId = id
                    });
                }
                car.PartsCars = carParts;
                cars.Add(car);
            }
            context.AddRange(cars);
            context.SaveChanges();
            return $"Successfully imported {cars.Count}";
        }

        public static string ImportCustomers(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(CustomerDTO[]), new XmlRootAttribute("Customers"));

            using var reader = new StringReader(inputXml);

            CustomerDTO[] customerDTOs = (CustomerDTO[])xmlSerializer.Deserialize(reader);

            var mapper = GetMapper();

            Customer[] customers = mapper.Map<Customer[]>(customerDTOs);

            context.Customers.AddRange(customers);
            context.SaveChanges();

            return $"Successfully imported {customers.Length}";
        }

        public static string ImportSales(CarDealerContext context, string inputXml)
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(SaleDTO[]), new XmlRootAttribute("Sales"));

            using var reader = new StringReader(inputXml);

            SaleDTO[] saleDTOs = (SaleDTO[])xmlSerializer.Deserialize(reader);

            var mapper = GetMapper();

            int[] carIds = context.Cars.Select(c => c.Id).ToArray();

            Sale[] sales = mapper.Map<Sale[]>(saleDTOs).Where(s => carIds.Contains(s.CarId)).ToArray();

            context.Sales.AddRange(sales);
            context.SaveChanges();
            return $"Successfully imported {sales.Length}";
        }

        public static string GetCarsWithDistance(CarDealerContext context)
        {
            var mapper = GetMapper();
            var xParser = new XParser();

            var result = context.Cars
                .Where(c => c.TraveledDistance > 2000000)
                .OrderBy(c => c.Make)
                .ThenBy(c => c.Model)
                .Take(10)
                .ProjectTo<CarsWithDistance>(mapper.ConfigurationProvider)
                .ToArray();

            return xParser.Serialize<CarsWithDistance[]>(result, "cars");
        }

        public static string GetCarsFromMakeBmw(CarDealerContext context)
        {
            var mapper = GetMapper();

            var xParser = new XParser();
            var result = context.Cars
                .Where(c => c.Make == "BMW")
                .OrderBy(c => c.Model)
                .ThenByDescending(c => c.TraveledDistance)
                .ProjectTo<CarsFromMakeBmw>(mapper.ConfigurationProvider)
                .ToArray();

            return xParser.Serialize<CarsFromMakeBmw>(result, "cars");
        }

        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var mapper = GetMapper();

            var xParser = new XParser();
            var result = context.Suppliers
                .Where(s => s.IsImporter == false)
                .Select(s => new LocalSuppliers
                {
                    Id = s.Id,
                    Name = s.Name,
                    PartsCount = s.Parts.Count,
                })
                .ToArray();

            return xParser.Serialize<LocalSuppliers>(result, "suppliers");

        }

        public static string GetCarsWithTheirListOfParts(CarDealerContext context)
        {
            var mapper = GetMapper();

            var xParser = new XParser();

            var result = context.Cars
                .Select(c => new CarsWithTheirListOfParts
                {
                    Make = c.Make,
                    Model = c.Model,
                    TraveledDistance = c.TraveledDistance,
                    Parts = c.PartsCars.Select(pc => new ExportPart()
                    {
                        Name = pc.Part.Name,
                        Price = pc.Part.Price,
                    })
                    .OrderByDescending(pc => pc.Price)
                    .ToArray()
                })
                .OrderByDescending(c => c.TraveledDistance)
                .ThenBy(c => c.Model)
                .Take(5)
                .ToArray();

            return xParser.Serialize<CarsWithTheirListOfParts>(result, "cars");
        }

        public static string GetTotalSalesByCustomer(CarDealerContext context)
        {
            
            
            var mapper = GetMapper();

            var xParser = new XParser();

            var totalSales = context.Customers
                .Where(c => c.Sales.Any())
                .Select(c => new TotalSalesByCustomer
                {
                    FullName = c.Name,
                    BoughtCars = c.Sales.Count,
                    SpentMoney = c.Sales.Sum(s =>
                        s.Car.PartsCars.Sum(pc =>
                            Math.Round(c.IsYoungDriver ? pc.Part.Price * 0.95m : pc.Part.Price, 2)))
                })
                .OrderByDescending(s => s.SpentMoney)
                .ToArray();



            return xParser.Serialize<TotalSalesByCustomer[]>(totalSales, "customers");
        }

        public static string GetSalesWithAppliedDiscount(CarDealerContext context)
        {
            var xParser = new XParser();

            SalesWithAppliedDiscount[] sales = context.Sales
                .Select(s => new SalesWithAppliedDiscount()
                {
                    Car = new CurrentCar()
                    {
                        Make = s.Car.Make,
                        Model = s.Car.Model,
                        TraveledDistance = s.Car.TraveledDistance
                    },
                    Discount = (int)s.Discount,
                    CustomerName = s.Customer.Name,
                    Price = s.Car.PartsCars.Sum(p => p.Part.Price),
                    PriceWithDiscount =
                        Math.Round((double)(s.Car.PartsCars
                            .Sum(p => p.Part.Price) * (1 - (s.Discount / 100))), 4)
                })
                .ToArray();

            return xParser.Serialize<SalesWithAppliedDiscount[]>(sales, "sales");
                
        }
    }
}