using AutoMapper;
using CarDealer.DTOs.Export;
using CarDealer.DTOs.Import;
using CarDealer.Models;

namespace CarDealer
{
    public class CarDealerProfile : Profile
    {
        public CarDealerProfile()
        {
            CreateMap<SupplierDTO, Supplier>();

            CreateMap<PartDTO, Part>();

            CreateMap<CarDTO, Car>();

            CreateMap<CustomerDTO, Customer>();

            CreateMap<SaleDTO, Sale>();

            CreateMap<Car, CarsWithDistance>();

            CreateMap<Car, CarsFromMakeBmw>();

        }
    }
}
