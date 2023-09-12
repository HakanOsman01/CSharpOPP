using System;
using System.Collections.Generic;

namespace Cars
{
    public class Tesla : ICar, IElectricalCar
    {
        public Tesla(string model,string color,int battery)
        {
            Model = model;
            Color = color;
            Battery = battery;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public int Battery { get; set; }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} Batteries";
        }
    }
}
