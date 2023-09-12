using System;
using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;

namespace EDriveRent.Models
{
    public class User : IUser
    {
        private string firstName;
        private string lastName;
        private string drivingLicenseNumber;
        private const double IncreaseRatingWhenDrive = 0.5;
        private const double DecraseRatingWhenDrive = 2.0;
        public User(string firstName, string lastName, string drivingLicenseNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DrivingLicenseNumber = drivingLicenseNumber;
            this.IsBlocked = false;
            this.Rating = 0;
            
        }

        public string FirstName
        {
            get => firstName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.FirstNameNull);
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get=>lastName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.LastNameNull);
                }
                lastName = value;
            }
        }
        public double Rating { get;private set; }

       

        public string DrivingLicenseNumber
        {
            get => drivingLicenseNumber;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.DrivingLicenseRequired);
                }
                drivingLicenseNumber = value;
            }
        }

        public bool IsBlocked { get; private set; }

        public void DecreaseRating()
        {
            this.Rating -= DecraseRatingWhenDrive;
            if (this.Rating < 0.0)
            {
                this.Rating = 0.0;
                IsBlocked = true;
            }
        }

        public void IncreaseRating()
        {
            this.Rating += IncreaseRatingWhenDrive;
            if (Rating > 10.0)
            {
                Rating = 10.0;
            }
            
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} " +
                $"Driving license: {this.drivingLicenseNumber} Rating: {this.Rating}";
        }
    }
}
