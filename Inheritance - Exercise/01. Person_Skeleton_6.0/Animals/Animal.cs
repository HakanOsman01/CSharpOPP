using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public abstract class Animal
    {
        private string _name;
        private int _age;
        private string _genger;

        protected Animal(string name,int age,string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }
        public string Name
        {
            get 
            { 
                return _name; 
            }
            set 
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(nameof(this.Name),"Cannot be null");
                }
                else
                {
                    _name = value;
                }
            }
        }
        public int Age 
        {
            get
            {
                return _age;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Cannot be negative age");
                }
                else
                {
                    this._age = value;
                }
            }
        }
        public string Gender
        {
            get
            {
                return _genger;
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Gender cannot be null or empty");
                }
                else
                {
                    this._genger= value;
                }
            }
        }
        public abstract string ProduceSound();
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}")
             .AppendLine($"{this.Name} {this.Age} {this.Gender}")
             .AppendLine($"{this.ProduceSound()}");
            return sb.ToString().TrimEnd();
        }

    }
}
