using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects.Foods
{
    public abstract class Food : Point
    {

        private char foodSymbol;
        private Random random;
        private Wall wall;
        public Food(Wall wall,char foodSymbol,int points) 
            : base(wall.LeftX, wall.TopY)
        {
            this.wall = wall;
            random= new Random();
            this.foodSymbol = foodSymbol;
            this.FoodPoints = points;

        }
        public int FoodPoints { get; private set; }
        public void SetRandomPosition(Queue<Point>snakeElements)
        {
            LeftX=random.Next(2,this.wall.LeftX-2);
            TopY=random.Next(2,this.wall.TopY-2);
            bool isPointOfSnake=snakeElements
             .Any(s=>s.LeftX==this.LeftX && s.TopY==this.TopY);
            while (isPointOfSnake)
            {
                LeftX = random.Next(2, this.wall.LeftX - 2);
                TopY = random.Next(2, this.wall.TopY - 2);
                isPointOfSnake = snakeElements
             .Any(s => s.LeftX == this.LeftX && s.TopY == this.TopY);
            }
            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(foodSymbol);
            Console.BackgroundColor = ConsoleColor.White;

        }
        public bool IsFoodPoint(Point snakeHead) => snakeHead.TopY == this.TopY 
            && snakeHead.LeftX == this.LeftX;
        
    }
}
