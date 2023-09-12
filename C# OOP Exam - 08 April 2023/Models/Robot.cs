using System;
using RobotService.Models.Contracts;
using System.Collections.Generic;
using RobotService.Utilities.Messages;
using System.Text;
using System.Linq;

namespace RobotService.Models
{
    public abstract class Robot : IRobot
    {
        private string model;
        private int batteryCapacity;
        private int batteryLevel;
        private int convertionCapacityIndex;
        private List<int> interfaceStandards;
        protected Robot(string model, int batteryCapacity, int conversionCapacityIndex)
        {
            this.Model = model;
            this.BatteryCapacity = batteryCapacity;
            this.batteryLevel = BatteryCapacity;
            this.convertionCapacityIndex = conversionCapacityIndex;
            interfaceStandards= new List<int>();
        }

        public string Model
        {
            get => model;
            private set
            {
                if (string.IsNullOrWhiteSpace(model))
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.ModelNullOrWhitespace));

                }
                model = value;
            }
        }

        public int BatteryCapacity
        {
            get => batteryCapacity;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(string.Format(ExceptionMessages.BatteryCapacityBelowZero));
                }
                batteryCapacity = value;
            }


        }

        public int BatteryLevel => batteryLevel;
        

        public int ConvertionCapacityIndex => convertionCapacityIndex;

        public IReadOnlyCollection<int> InterfaceStandards
        {
            get { return this.interfaceStandards.AsReadOnly(); }
        }

        public void Eating(int minutes)
        {
            int totalCapacity = convertionCapacityIndex * minutes;

            if (totalCapacity > BatteryCapacity - BatteryLevel)
            {
                batteryLevel = batteryCapacity;
            }
            else
            {
                batteryLevel += totalCapacity;
            }

        }

        public bool ExecuteService(int consumedEnergy)
        {
            if (batteryLevel >= consumedEnergy)
            {
                batteryLevel-= consumedEnergy;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void InstallSupplement(ISupplement supplement)
        {
            this.interfaceStandards.Add(supplement.InterfaceStandard);
            this.BatteryCapacity -= supplement.BatteryUsage;
            this.batteryLevel -= supplement.BatteryUsage;
        }
        public override string ToString()
        {
          StringBuilder sb= new StringBuilder();
            sb.AppendLine($"{this.GetType().Name} {Model}:");
            sb.AppendLine($"--Maximum battery capacity: {BatteryCapacity}");
            sb.AppendLine($"--Current battery level: {BatteryLevel}");
            sb.AppendLine("--Supplements installed: ");
            if (interfaceStandards.Count == 0)
            {
                sb.Append("none");
            }
            else
            {

                sb.Append($"{string.Join(" ",interfaceStandards)}");
            }
            return sb.ToString().Trim();
        }
    }
}
