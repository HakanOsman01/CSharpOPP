using System;
using System.Collections.Generic;
using System.Text;

namespace P01._Square_Before
{
    public class Square : Shape
    {
        private double side;
        public Square(int side)
        {
            this.Side = side;
        }
        public double Side 
        {
            get
            {
                return side;
            }
            set 
            { 
                side = value; 
            }
        }

        public override double Area => side * side;
       
    }
}
