using AutoMapper;
using CarDealer.Data;
using CarDealer.DTOs.Import;
using CarDealer.Models;
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

            string inputCars = File.ReadAllText("../../../Datasets/cars.xml");
            Console.WriteLine(ImportCars(db, inputCars));
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
    }
}