using _04._Border_Control.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Border_Control.Models
{
    public class Robot : IIedentife
    {
        public Robot(string model,string Id)
        {
            this.Model=model;
            this.Id = Id;
        }
        public string Id { get;private set; }
        public string  Model { get; private set; }
       
    }
}
