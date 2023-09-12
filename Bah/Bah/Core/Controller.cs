using EDriveRent.Core.Contracts;
using EDriveRent.Models;
using EDriveRent.Models.Contracts;
using EDriveRent.Repositories;
using EDriveRent.Utilities.Messages;
using System.Runtime.Serialization;
using System.Reflection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EDriveRent.Core
{
    public class Controller:IController
    {
        private UserRepository users;
        private RouteRepository routes;
        private VehicleRepository vehicles;
        public Controller()
        {
            this.users = new UserRepository();
            this.routes = new RouteRepository();
            this.vehicles = new VehicleRepository();
        }

        public string AllowRoute(string startPoint, string endPoint, double length)
        {
            IReadOnlyCollection<IRoute> findRoutes = this.routes.GetAll();
            foreach (IRoute route in findRoutes)
            {
                if(route.StartPoint==startPoint 
                    && route.EndPoint==endPoint && route.Length == length)
                {
                    return string
                        .Format(OutputMessages.RouteExisting,startPoint,endPoint,length);
                }
                else if(route.StartPoint == startPoint
                    && route.EndPoint == endPoint && route.Length < length)
                {
                    return string.Format(OutputMessages.RouteIsTooLong,startPoint,endPoint);
                }
                else if(route.StartPoint == startPoint
                    && route.EndPoint == endPoint && route.Length > length)
                {
                    IRoute currentRoute=route;
                    string routeId =currentRoute.RouteId.ToString();

                    IRoute findRoute = this.routes.FindById(routeId);
                    findRoute.LockRoute();
                 }
               
            }
            IRoute crateRoute = new Route(startPoint, endPoint, length, findRoutes.Count + 1);
            this.routes.AddModel(crateRoute);

            return string.Format(OutputMessages.NewRouteAdded,startPoint,endPoint,length);



        }

        public string MakeTrip(string drivingLicenseNumber, string licensePlateNumber, string routeId, bool isAccidentHappened)
        {
            //IReadOnlyCollection<IUser> allUsers = this.users.GetAll();
            IVehicle vehicle = this.vehicles.FindById(licensePlateNumber);
            IRoute route = this.routes.FindById(routeId);
            IUser user=this.users.FindById(drivingLicenseNumber);
            if (user.IsBlocked == true)
            {
                return string.Format(OutputMessages.UserBlocked, drivingLicenseNumber);
            }
            if (vehicle.IsDamaged == true)
            {
                return string.Format(OutputMessages.VehicleDamaged, licensePlateNumber);
            }
            if (route.IsLocked == true)
            {
                return string.Format(OutputMessages.RouteLocked, routeId);
            }
            
           
           
            
          
            vehicle.Drive(route.Length);
            if (isAccidentHappened == true)
            {
                vehicle.ChangeStatus();
                user.DecreaseRating();
            }
            else
            {
                vehicle.ChangeStatus();
                user.IncreaseRating();
            }
            return vehicle.ToString();


        }

        public string RegisterUser(string firstName, string lastName
            ,string drivingLicenseNumber)
        {
           
            if (users.FindById(drivingLicenseNumber) == null)
                
            {
                IUser user = new User(firstName, lastName, drivingLicenseNumber);
                this.users.AddModel(user);
                return string.Format(OutputMessages.UserSuccessfullyAdded, firstName, lastName,drivingLicenseNumber);

            }
            else
            {
                return string.Format(OutputMessages.UserWithSameLicenseAlreadyAdded, drivingLicenseNumber);


            }
        }

        public string RepairVehicles(int count)
        {
            IReadOnlyList<IVehicle> reapirvehicles =
                (IReadOnlyList<IVehicle>) this.vehicles.GetAll();

            reapirvehicles = reapirvehicles.Where(d => d.IsDamaged == true).ToList();

            int countOfRepairVehicles = 0;
            foreach (IVehicle vehicle in
                reapirvehicles.OrderBy(v=>v.Brand)
                .ThenBy(m=>m.Model)
                .Take(count))
            {
                IVehicle vehicleToReapair 
                    = this.vehicles.FindById(vehicle.LicensePlateNumber);
                vehicleToReapair.ChangeStatus();
                vehicleToReapair.Recharge();
                countOfRepairVehicles++;
            }

            return string.Format(OutputMessages.RepairedVehicles, countOfRepairVehicles);
           
              
                

        }

        public string UploadVehicle(string vehicleType, string brand, 
            string model, string licensePlateNumber)
        {
            string passengeCarName= typeof(PassengerCar).Name;
            string cargoVanName= typeof(CargoVan).Name;
            if(vehicleType!=passengeCarName && vehicleType != cargoVanName)
            {
                return string.Format(OutputMessages.VehicleTypeNotAccessible, vehicleType);
            }
            //IReadOnlyCollection<IUser>uploadUsers=this.users.GetAll();
            
            if (this.vehicles.FindById(licensePlateNumber)!=null)
            {
                return string.Format(OutputMessages.LicensePlateExists, licensePlateNumber);
            }
            IVehicle vehicle=null;
            if (vehicleType == "PassengerCar")
            {
                vehicle=new PassengerCar(brand, model,licensePlateNumber);
            }
            else if (vehicleType == "CargoVan")
            {
                vehicle=new CargoVan(brand, model,licensePlateNumber);
            }
            this.vehicles.AddModel(vehicle);
            return string.Format(OutputMessages.VehicleAddedSuccessfully, brand, model, licensePlateNumber);

        }

        public string UsersReport()
        {
            StringBuilder sb=new StringBuilder();
            IReadOnlyList<IUser> userReport = 
                (IReadOnlyList<IUser>)this.users.GetAll();
            userReport = userReport
                .OrderByDescending(r => r.Rating)
                .ThenBy(l => l.LastName)
                .ThenBy(f => f.FirstName)
                .ToList();
            sb.AppendLine("*** E-Drive-Rent ***");
            foreach(IUser user in userReport)
            {
                IUser findUser = this.users.FindById(user.DrivingLicenseNumber);
                sb.AppendLine(findUser.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
