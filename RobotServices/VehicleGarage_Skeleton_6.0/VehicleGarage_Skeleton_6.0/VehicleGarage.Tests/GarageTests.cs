using NUnit.Framework;
using System;
using System.Linq;

namespace VehicleGarage.Tests
{
    public class Tests
    {
        private Garage garage;
        [SetUp]
        
        public void Setup()
        {
            garage = new Garage(5);

        }

        [Test]
        public void Test_Does_Constructor_Set_Values_Correctly()
        {
            int expectCapacity = 5;
            int actualCapacity= garage.Capacity;
            Assert.AreEqual(expectCapacity, actualCapacity);
            Assert.IsNotNull(garage.Vehicles);
        }
        [Test]
        public void Test_Setters_Of_Properties()
        {
            garage.Capacity = 10;
            Vehicle vehicle = new Vehicle("BWV", "Pesho", "1294y412");
            garage.Vehicles.Add(vehicle);
            Assert.AreEqual(10,garage.Capacity);
            Assert.AreEqual(garage.Vehicles[0].Model, vehicle.Model);
            Assert.AreEqual(garage.Vehicles[0].Brand, vehicle.Brand);
            Assert.AreEqual(garage.Vehicles[0].LicensePlateNumber, 
                vehicle.LicensePlateNumber);

        }
        [Test]
        public void Test_AddVehicle_Method_With_False_Capacity_Equal_To_CapacityOfGarage()
        {
            garage=new Garage(0);
            Vehicle vehicle = new Vehicle("BWV", "Pesho", "1294y412");
            bool actualResult = garage.AddVehicle(vehicle);
            Assert.IsFalse(actualResult);
        }
        [Test]
        public void Test_AddVehicle_Method_With_False_With_Same_Licence_Plate_Number()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            Vehicle vehicle2 = new Vehicle("Audi", "Gosho", "1294y412");
            _ = garage.AddVehicle(vehicle1);
            bool actualResult = garage.AddVehicle(vehicle2);
            Assert.IsFalse(actualResult);
        }

        [Test]
        public void Test_AddVehicle_Succesesly_And_Correctly()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            bool result=garage.AddVehicle(vehicle1);
            Assert.AreEqual("BWV", vehicle1.Brand);
            Assert.AreEqual("Pesho", vehicle1.Model);
            Assert.AreEqual("1294y412", vehicle1.LicensePlateNumber);
            Assert.IsTrue(result);


        }
        [Test]
        public void Test_Charge_Method_With_Zero_Charge_Cars()
        {
            int actualResult = garage.ChargeVehicles(6);
            Assert.AreEqual(0, actualResult);
        }
        [Test]
        public void Test_Charge_Method_With_Two_Charge_Cars()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            Vehicle vehicle2 = new Vehicle("Audi", "Gosho", "1294y413");
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle2);
            int actualResult=garage.ChargeVehicles(101);
            Assert.AreEqual(2, actualResult);
        }
        [Test]
        public void Test_DriveCar_When_IsDamaged()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            garage.AddVehicle(vehicle1);
            vehicle1.IsDamaged = true;
            Assert.IsTrue(vehicle1.IsDamaged);
            garage.DriveVehicle(vehicle1.LicensePlateNumber, 30, false);
            Assert.AreEqual(100, vehicle1.BatteryLevel);

        }
        [Test]
        public void Test_DriveCar_When_BatteryDirangeIsHigherThan100()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            garage.AddVehicle(vehicle1);
            Assert.IsFalse(vehicle1.IsDamaged);
            garage.DriveVehicle(vehicle1.LicensePlateNumber, 101, false);
            Assert.AreEqual(100, vehicle1.BatteryLevel);

        }
        [Test]
        public void Test_DriveCar_When_BatteryDirangeIsBiggerThanBatteryLevel()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            vehicle1.BatteryLevel = 10; 
            garage.AddVehicle(vehicle1);
            Assert.AreEqual(10,vehicle1.BatteryLevel);
            garage.DriveVehicle(vehicle1.LicensePlateNumber, 15, false);
            Assert.AreEqual(10, vehicle1.BatteryLevel);

        }
        [Test]
        public void Test_DriveCar_Decrease_BatteryLevelWith_No_Accident()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            garage.AddVehicle(vehicle1);
            garage.DriveVehicle(vehicle1.LicensePlateNumber,30,false);
            Assert.AreEqual(70,vehicle1.BatteryLevel);
            Assert.IsFalse(vehicle1.IsDamaged);

        }
        [Test]
        public void Test_DriveCar_Decrease_BatteryLevelWith_Accident()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            garage.AddVehicle(vehicle1);
            garage.DriveVehicle(vehicle1.LicensePlateNumber, 30, true);
            Assert.AreEqual(70, vehicle1.BatteryLevel);
            Assert.IsTrue(vehicle1.IsDamaged);

        }
        [Test]
        public void Test_DriveCar_Decrease_BatteryLevelWith_NotFound_Car()
        {
            Assert.Throws<NullReferenceException>(() =>
            {
                garage.DriveVehicle("1234", 3, false);
            });
        }
        [Test]
        public void Test_Repair_Vehicles_With_Empty_Collection()
        {
            string actulaMessage=garage.RepairVehicles();
            string expectedMessage = $"Vehicles repaired: 0";
            Assert.AreEqual(expectedMessage, actulaMessage);


        }
        [Test]
        public void Test_Repair_Vehicles_With_Two_CarDamege()
        {
            Vehicle vehicle1 = new Vehicle("BWV", "Pesho", "1294y412");
            Vehicle vehicle2 = new Vehicle("Audi", "Gosho", "1294y413");
            garage.AddVehicle(vehicle1);
            garage.AddVehicle(vehicle1);
            vehicle1.IsDamaged = true;
            string actualMessage = garage.RepairVehicles();
            string expectedMessages= $"Vehicles repaired: 1";
            Assert.IsFalse(vehicle1.IsDamaged);
            Assert.AreEqual(expectedMessages, actualMessage);


        }
    }
}