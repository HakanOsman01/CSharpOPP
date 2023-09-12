



namespace _01._Vehicles.Core
{
    using _01._Vehicles.Models;
    using _01._Vehicles.Models.Interfaces;
    using Interfaces;
    public class Engine : IEngine
    {
        public void Run()

        {
           
            string[]tokensCar=Console.ReadLine()
          .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            double carFuelQuantity = double.Parse(tokensCar[1]);
            double carFuelConsumption = double.Parse(tokensCar[2]);
            int capacityCar = int.Parse(tokensCar[3]);

            IDrivable car = new Car(carFuelQuantity, carFuelConsumption,capacityCar);
            string[]tokensTruck= Console.ReadLine()
           .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            double truckFuelQuantity = double.Parse(tokensTruck[1]);
            double truckFuelConsumption = double.Parse(tokensTruck[2]);
            int capacityTruck = int.Parse(tokensTruck[3]);

            IDrivable truck = new Truck(truckFuelQuantity, 
                truckFuelConsumption,capacityTruck);

            string[] tokensBus = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double busFuelQuantity = double.Parse(tokensBus[1]);
            double busFuelConsumption = double.Parse(tokensBus[2]);
            int capacityBus = int.Parse(tokensBus[3]);

            IDrivable bus = new Bus(busFuelQuantity, busFuelConsumption, capacityBus);

            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                string[] tokens = Console.ReadLine()
              .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string type = tokens[0];
                string typeVehicle= tokens[1];
                switch(type)
                {
                    case "Drive":
                        double km = double.Parse(tokens[2]);
                        if (typeVehicle == "Car")
                        {

                            DriveVehicle(car, km);
                        }
                        else if(typeVehicle=="Truck")
                        {
                            DriveVehicle(truck, km);
                        }
                        else
                        {
                            DriveVehicle(bus, km,false);
                        }
                        break;
                    case "Refuel":
                        double fuel= double.Parse(tokens[2]);
                        bool isFuelNegativeNumber = IsFuelNegative(fuel);
                        if (isFuelNegativeNumber)
                        {
                            Console.WriteLine("Fuel must be a positive number");
                        }
                        else
                        {
                            if (typeVehicle == "Car")
                            {
                                RefuleVehicle(car, fuel);
                            }
                            else if (typeVehicle == "Truck")
                            {
                                RefuleVehicle(truck, fuel);
                            }
                            else
                            {
                                RefuleVehicle(bus,fuel);
                            }
                        }

                        break;
                    case "DriveEmpty ":
                      double kmBus = double.Parse(tokens[2]);
                        DriveVehicle(bus, kmBus, true);
                        break;

                }

            }
            Console.WriteLine(car);
            Console.WriteLine(truck);
            Console.WriteLine(bus);

        }
        private void DriveVehicle(IDrivable vehicle,double km)
        {
            vehicle.Drive(km);
        }
        private void DriveVehicle(IDrivable vehicle, double km,bool isEmpty)
        {
            if(vehicle is Bus)
            {
                if(isEmpty)
                {
                    ((Bus)vehicle).Drive(km,isEmpty);
                }
                else
                {
                    ((Bus)vehicle).Drive(km,isEmpty);
                }
            }
        }
        private void RefuleVehicle(IDrivable vehicle,double fuel)
        {
            vehicle.Refueled(fuel);
        }
       
        private bool IsFuelNegative(double fuel)
        {
            if (fuel <= 0)
            {
                return true;
            }
            return false;
            
        }
    }
}
