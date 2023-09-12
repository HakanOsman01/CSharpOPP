using BookingApp.Models.Bookings.Contracts;
using BookingApp.Models.Rooms.Contracts;
using BookingApp.Utilities.Messages;
using System;
using System.Text;

namespace BookingApp.Models.Bookings
{
    public class Booking : IBooking
    {
        private int residenceDuration;
        private int adultsCount;
        private int childrenCount;
        public Booking(IRoom room, int residenceDuration, int adultsCount, 
            int childrenCount, int bookingNumber)
        {
            this.Room= room;
            this.ResidenceDuration= residenceDuration;
            this.AdultsCount= adultsCount;
            this.ChildrenCount= childrenCount;
            this.BookingNumber= bookingNumber;
            
        }

        public IRoom Room { get;private set; }

        public int ResidenceDuration
        {
            get => residenceDuration;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.DurationZeroOrLess);
                }
                residenceDuration = value;
            }
        }

        public int AdultsCount
        {
            get => adultsCount;
            private set
            {
                if (adultsCount < 1)
                {
                    throw new ArgumentException(ExceptionMessages.AdultsZeroOrLess);
                }
            }
        }

        public int ChildrenCount
        {
            get => childrenCount;
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException(ExceptionMessages.ChildrenNegative);
                }
            }
        }

        public int BookingNumber { get;private set; }

        public string BookingSummary()
        {
           StringBuilder sb= new StringBuilder();
            sb.AppendLine($"Booking number: {this.BookingNumber}")
                .AppendLine($"Room type: {Room.GetType().Name}")
                .AppendLine($"Adults: {this.AdultsCount} Children: {this.ChildrenCount}")
                .AppendLine($"Total amount paid: {TotalPaid():F2} $");

            return sb.ToString().TrimEnd();
        }
        private double TotalPaid()
            =>Math.Round(this.ResidenceDuration*this.Room.PricePerNight,2);
        
    }
}
