
namespace Gym.Models.Gyms
{
    using System;
    using System.Collections.Generic;
    using Athletes.Contracts;
    using Equipment.Contracts;
    using Contracts;
    using Utilities.Messages;
    using System.Linq;
    using System.Text;

    public abstract class Gym : IGym
    {
        private string name;

        public Gym(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
            Athletes= new List<IAthlete>();
            Equipment=new List<IEquipment>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            private  set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidGymName);
                }
                name = value;
            }
        }

        public int Capacity { get; private set; }


        public double EquipmentWeight
        {
            get
            {
                return this.Equipment.Select(e=>e.Weight).Sum();
            }
        }

        public ICollection<IEquipment> Equipment { get; private set; }

        public ICollection<IAthlete> Athletes { get; private set; }

        public void AddAthlete(IAthlete athlete)
        {
            if (this.Capacity <= this.Athletes.Count)
            {
                throw new ArgumentException(ExceptionMessages.NotEnoughSize);

            }
            this.Athletes.Add(athlete);
        }

        public void AddEquipment(IEquipment equipment)
        {
            this.Equipment.Add(equipment);
        }

        public void Exercise()
        {
            foreach (var athlete in this.Athletes)
            {
                athlete.Exercise();
            }
        }

        public string GymInfo()
        {
          StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"{Name} is a {this.GetType().Name}:");
            stringBuilder.AppendLine("Athletes:");
            if (this.Athletes.Count > 0)
            {
                string[]names=this.Athletes.Select(a=>a.FullName).ToArray();
                stringBuilder.AppendLine($"{string.Join(", ", names)}");
            }
            else
            {
                stringBuilder.AppendLine("No athletes");
            }
            stringBuilder.AppendLine($"Equipment total count: {this.Equipment.Count}");
            stringBuilder.AppendLine($"Equipment total weight: " +
                $"{EquipmentWeight:f2} grams");
            return stringBuilder.ToString().Trim();
        }

        public bool RemoveAthlete(IAthlete athlete)
        {
             IAthlete findAthelete=this.Athletes
                .FirstOrDefault(a=>a.FullName==athlete.FullName);
            if(findAthelete==null)
            {
                return false;
            }
            this.Athletes.Remove(athlete); 
            return true;
        }
    }
}
