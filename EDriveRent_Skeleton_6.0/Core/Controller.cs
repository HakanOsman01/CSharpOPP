using EDriveRent.Core.Contracts;
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDriveRent.Core
{
    public class Controller : IController
    {
        private UserRepository users;
        private VehicleRepository vehicles;
        private RouteRepository routes;
        public Controller()
        {
            users = new UserRepository();
            vehicles = new VehicleRepository();
            routes = new RouteRepository();
        }
        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            IReadOnlyList<IRoute> allRoutes = (IReadOnlyList<IRoute>)this.routes.GetAll();
           if(allRoutes.FirstOrDefault(r=>r.StartPoint==startPoint 
           && r.EndPoint==endPoint && r.Length == length) != null)
           {
                return String.Format(OutputMessages.RouteExisting,startPoint,endPoint,length);
           }
          
           if(allRoutes.FirstOrDefault(r => r.StartPoint == startPoint
           && r.EndPoint == endPoint && r.Length <length) != null)
           {
                return String.Format(OutputMessages.RouteIsTooLong
                    ,startPoint,endPoint,length);
           }
           IRoute route=new Route(startPoint,endPoint,length,allRoutes.Count+1);
            this.routes.AddModel(route);
            IRoute longRoute = allRoutes.FirstOrDefault(r => r.StartPoint == startPoint
           && r.EndPoint == endPoint && r.Length > length);
            if (longRoute != null)
            {
                longRoute.LockRoute();
            }
            return String.Format(OutputMessages.NewRouteAdded, startPoint, endPoint, length);
        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
           IUser user=this.users.FindById(drivingLicenseNumber);
            if (user.IsBlocked == true)
            {
                return String.Format(OutputMessages.UserBlocked, drivingLicenseNumber);
            }
            IVehicle vehicle=this.vehicles.FindById(licensePlateNumber);
            if (vehicle.IsDamaged == true)
            {
                return String.Format(OutputMessages.VehicleDamaged, licensePlateNumber);
            }
            IRoute route=this.routes.FindById(routeId);
            if(route.IsLocked==true)
            {
                return String.Format(OutputMessages.RouteLocked, routeId);
            }
            vehicle.Drive(route.Length);
            if(isAccidentHappened == true)
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
             
            if (this.users.FindById(drivingLicenseNumber)!=null)
            {
                return String.Format(OutputMessages
                    .UserWithSameLicenseAlreadyAdded,drivingLicenseNumber);
            }
            User user=new User(firstName, lastName, drivingLicenseNumber);
            users.AddModel(user);
            return String.Format(OutputMessages.UserSuccessfullyAdded, 
                firstName, lastName, drivingLicenseNumber);
        }

        public string RepairVehicles(int count)
        {
            IReadOnlyList<IVehicle> allVehicles = (IReadOnlyList<IVehicle>)
                this.vehicles.GetAll();
            List<IVehicle>onlyRepairVehicles= allVehicles.Where(v=>v.IsDamaged==true).ToList();
            if (onlyRepairVehicles.Count >count)
            {
                onlyRepairVehicles = onlyRepairVehicles.
                    OrderBy(v => v.Brand)
                    .OrderBy(v => v.Model)
                    .Take(count)
                    .ToList();
            }
            else
            {
                onlyRepairVehicles = onlyRepairVehicles.
                   OrderBy(v => v.Brand)
                   .OrderBy(v => v.Model)
                   .ToList();
            }
            
            foreach (var vehicle in onlyRepairVehicles)
            {
                vehicle.ChangeStatus();
                vehicle.Recharge();

            }
            return String.Format(OutputMessages.RepairedVehicles, onlyRepairVehicles.Count);
        }

        public string UploadVehicle(string vehicleType, string brand, string model, string licensePlateNumber)
        {
           if(vehicleType != "PassengerCar" && vehicleType!= "CargoVan")
           {
                return String.Format(OutputMessages.VehicleTypeNotAccessible,vehicleType);
           }
          if (this.vehicles.FindById(licensePlateNumber) != null)
          {
                return String.Format(OutputMessages.LicensePlateExists,licensePlateNumber);
          }
          IVehicle vehicle = null;
            if (vehicleType == "PassengerCar")
            {
                vehicle = new PassengerCar(brand, model, licensePlateNumber);
            }
            else if (vehicleType == "CargoVan")
            {
                vehicle=new CargoVan(brand, model, licensePlateNumber);
            }
            this.vehicles.AddModel(vehicle);
            return String.Format(OutputMessages.VehicleAddedSuccessfully, 
                brand, model, licensePlateNumber);
        }

        public string UsersReport()
        {
            IReadOnlyList<IUser> allUsers = (IReadOnlyList<IUser>)
                this.users.GetAll();
            List<IUser>reportUsers=allUsers
                .OrderByDescending(u => u.Rating)
              .ThenBy(u => u.LastName)
              .ThenBy(u => u.FirstName)
              .ToList();


            StringBuilder sb=new StringBuilder();
            sb.AppendLine("*** E-Drive-Rent ***");
            foreach (IUser user in reportUsers) 
            {
                sb.AppendLine(user.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
