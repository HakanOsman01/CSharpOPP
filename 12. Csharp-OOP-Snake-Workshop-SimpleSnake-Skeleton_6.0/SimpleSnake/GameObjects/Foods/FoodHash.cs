using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects.Foods
{
    public class FoodHash : Food
    {
        private const char FoodSymbol = '#';
        private const int Point = 3;
        public FoodHash(Wall wall) 
            : base(wall, FoodSymbol,Point)
        {
        }
    }
}
