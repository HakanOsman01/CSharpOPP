using ChristmasPastryShop.Models.Cocktails.Contracts;
using ChristmasPastryShop.Models.Delicacies;
using ChristmasPastryShop.Models.Delicacies.Contracts;
using ChristmasPastryShop.Repositories;
using ChristmasPastryShop.Repositories.Contracts;
using ChristmasPastryShop.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChristmasPastryShop.Models.Booths
{
    public class Booth
    {
        private int capacity;
        private readonly IRepository<IDelicacy> delicacies;
        private readonly IRepository<ICocktail> cocktails;
        public Booth(int boothId, int capacity)
        {
            this.BoothId = boothId;
            this.Capacity = capacity;

            this.delicacies = new DelicacyRepository();
            this.cocktails = new CocktailRepository();

            this.CurrentBill = 0;
            this.Turnover = 0;

        }
        public int BoothId  { get; private set; }
        public int Capacity
        {
            get
            {
                return capacity;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.CapacityLessThanOne);
                }
                capacity = value;
            }
        }
        public IRepository<IDelicacy> DelicacyMenu => this.delicacies;
        public IRepository<ICocktail> CocktailMenu => this.cocktails;
        public double CurrentBill { get;private set; }
        public double Turnover { get; private set; }
        public bool IsReserved { get;private set; }
        public void UpdateCurrentBill(double amount)
        {
            this.CurrentBill += amount;
        }
        public void Charge()
        {
            this.Turnover += this.CurrentBill;
            this.CurrentBill = 0;
        }
        public void ChangeStatus()
        {
            if (this.IsReserved==true)
            {
                this.IsReserved= false;
            }
            else if(this.IsReserved==false)
            {
                this.IsReserved= true;
            }
        }
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.AppendLine($"Booth: {this.BoothId}");
            sb.AppendLine($"Capacity: {this.Capacity}");
            sb.AppendLine($"Turnover: {this.Turnover:f2} lv");
            sb.AppendLine($"-Cocktail menu:");
            foreach (ICocktail cocktail in CocktailMenu.Models)
            {
                sb.AppendLine($"--{cocktail.ToString()}");
            }
            sb.AppendLine("-Delicacy menu:");
            foreach (IDelicacy delicacy in DelicacyMenu.Models)
            {
                sb.AppendLine($"--{delicacy.ToString()}");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
