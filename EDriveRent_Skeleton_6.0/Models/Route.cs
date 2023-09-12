using EDriveRent.Models.Contracts;
using EDriveRent.Utilities.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            this.IsLocked = false;
        }
        public string StartPoint
        {
            get
            {
                return startPoint;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.StartPointNull);
                }
                startPoint = value;
            }
        }

        public string EndPoint
        {
            get
            {
                return endPoint;
            }
            private set
            {
                if (String.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.EndPointNull);
                }
               endPoint = value;
            }
        }

        public double Length
        {
            get
            {
                return lenght;
            }
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

        public bool IsLocked { get;private set; }

        public void LockRoute()
        {
            if (IsLocked == false)
            {
                IsLocked = true;
            }
        }
    }
}
