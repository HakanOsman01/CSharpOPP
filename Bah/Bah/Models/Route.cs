﻿
using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;

namespace EDriveRent.Models
{
    public class Route : IRoute
    {
        private string startPoint;
        private string endPoint;
        private double lenght;
        public Route(string startPoint, string endPoint, double length, int routeId)
        {
            this.StartPoint = startPoint;
            this.EndPoint = endPoint;
            this.Length = length;
            this.RouteId = routeId;
            this.IsLocked= false;
        }
        public string StartPoint
        {
            get => startPoint;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(ExceptionMessages.StartPointNull);
                }
               startPoint = value;
            }
        }

        public string EndPoint
        {
            get => endPoint;
            private set
            {
                if(string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.EndPointNull);
                }
                endPoint = value;
            }
        }

        public double Length
        {
            get => lenght;
            private set
            {
                if (value < 1)
                {
                    throw new ArgumentException(ExceptionMessages.RouteLengthLessThanOne);

                }
                lenght = value;
            }
        }

        public int RouteId { get;private set; }

        public bool IsLocked { get; private set; }

        public void LockRoute() => this.IsLocked = true;
        
    }
}
