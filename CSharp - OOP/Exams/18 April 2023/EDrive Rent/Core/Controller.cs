using EDriveRent.Core.Contracts;
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories;
using EDriveRent.Repositories.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Core
{
    public class Controller : IController
    {
        private readonly IRepository<IUser> users;
        private readonly IRepository<IVehicle> vehicles;
        private readonly IRepository<IRoute> routes;

        public Controller()
        {
            this.users = new UserRepository();
            this.vehicles = new VehicleRepository();
            this.routes = new RouteRepository();
        }
        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            var route = this.routes.GetAll().FirstOrDefault(x => x.StartPoint == startPoint && x.EndPoint == endPoint
            && x.Length == length);
            if(route != null)
            {
                return string.Format(OutputMessages.RouteExisting,startPoint, endPoint, length);
            }
            route = this.routes.GetAll().FirstOrDefault(x => x.StartPoint == startPoint && x.EndPoint == endPoint
            && x.Length < length);
             
            if (route != null)
            {
                return string.Format(OutputMessages.RouteIsTooLong, startPoint, endPoint);
            }

            route = this.routes.GetAll().FirstOrDefault(x => x.StartPoint == startPoint && x.EndPoint == endPoint
            && x.Length > length);

            if (route != null)
            {
                route.LockRoute();
            }
            var newRoute = new Route(startPoint, endPoint, length, routes.GetAll().Count + 1);
            this.routes.AddModel(newRoute);
            return string.Format(OutputMessages.NewRouteAdded, startPoint, endPoint, length);
        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            var user = this.users.FindById(drivingLicenseNumber);
            if (user.IsBlocked)
            {
                return string.Format(OutputMessages.UserBlocked, drivingLicenseNumber);
            }
            var vehicle = this.vehicles.FindById(licensePlateNumber);

            if(vehicle.IsDamaged)
            {
                return string.Format(OutputMessages.VehicleDamaged, licensePlateNumber);
            }
            var route = this.routes.FindById(routeId);
            if(route.IsLocked)
            {
                return string.Format(OutputMessages.RouteLocked, routeId);
            }
            vehicle.Drive(route.Length);

            if(isAccidentHappened)
            {
                vehicle.ChangeStatus();
                user.DecreaseRating();
            }
            else
            {
                user.IncreaseRating();
            }
            return vehicle.ToString();
        }

        public string RegisterUser(string firstName, string lastName, string drivingLicenseNumber)
        {
            var user = this.users.FindById(drivingLicenseNumber);
            if(user != null)
            {
                return string.Format(OutputMessages.UserWithSameLicenseAlreadyAdded, drivingLicenseNumber);
            }
            user = new User(firstName, lastName, drivingLicenseNumber);
            users.AddModel(user);
            return string.Format(OutputMessages.UserSuccessfullyAdded, firstName, lastName, drivingLicenseNumber);
        }

        public string RepairVehicles(int count)
        {
            var vehicleToRepair = this.vehicles.GetAll().Where(x => x.IsDamaged).OrderBy(x => x.Brand)
                .ThenBy(x => x.Model).Take(count).ToList();

            foreach(var vehicle in vehicleToRepair)
            {
                vehicle.ChangeStatus();
                vehicle.Recharge();
            }
            return String.Format(OutputMessages.RepairedVehicles, vehicleToRepair.Count);
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
            if (vehicleType != "CargoVan" && vehicleType != "PassengerCar")
            {
                return string.Format(OutputMessages.VehicleTypeNotAccessible, vehicleType);
            }
            var vehicle = this.vehicles.FindById(licensePlateNumber);
            if (vehicle != null)
            {
                return string.Format(OutputMessages.LicensePlateExists, licensePlateNumber);
            }
            if (vehicleType == "CargoVan")
            {
                vehicle = new CargoVan(brand, model, licensePlateNumber);
            }
            else
            {
                vehicle = new PassengerCar(brand, model, licensePlateNumber);
            }
            this.vehicles.AddModel(vehicle);
            return string.Format(OutputMessages.VehicleAddedSuccessfully, brand, model, licensePlateNumber);
        }

        public string UsersReport()
        {
            StringBuilder sb = new StringBuilder();
            var allUser = this.users.GetAll().OrderByDescending(x => x.Rating)
                .ThenBy(x => x.LastName)
                .ThenBy(x => x.FirstName).ToList();

            sb.AppendLine("*** E-Drive-Rent ***");

            foreach(var user in allUser)
            {
                sb.AppendLine(user.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
