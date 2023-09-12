using SimpleSnake.GameObjects.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public class Snake
    {
        private readonly Wall wall;
        private readonly Queue<Point> snakeElements;
        private readonly List<Food> foods;
        private const int DeFaultSnakeSize = 6;
        private int nextLeftX;
        private int nexTopY;
        private const char snakeSymbol = '\u25CF';
        private int foodIndex;
        private const char EmptySpace=' ';

        public Snake(Wall wall)
        {
            this.wall = wall;
            this.snakeElements = new Queue<Point>();
            this.foods= new List<Food>();
            this.foodIndex = RandomFoodNumber;
            this.GetFoods();
            this.CreateFood();
            this.CreateSnake();


        }
        public int FoodEaten { get;set; }
        public bool IsMoving(Point direction)
        {
            Point currentSnakeHead=snakeElements.Last();
            GetNextPosition(direction, currentSnakeHead);
            bool isPointOfSnake = snakeElements.Any(se =>
            se.LeftX == nextLeftX && se.TopY == nexTopY);
            if (isPointOfSnake)
            {
                return false;
            }
            Point newSnakeHead=new Point(nextLeftX, nexTopY);
            if(wall.IsPointOfWall(newSnakeHead))
            {
                return false;
            }
            snakeElements.Enqueue(newSnakeHead);
            newSnakeHead.Draw(snakeSymbol);
            if (foods[foodIndex].IsFoodPoint(newSnakeHead))
            {
                this.Eat(direction, currentSnakeHead);
            }

            Point snakeTail = snakeElements.Dequeue();
            snakeTail.Draw(EmptySpace);
            return true;
        }

        private void Eat(Point direction, Point currentSnakeHead)
        {
            int lenght = foods[foodIndex].FoodPoints;
            for (int i = 0; i < lenght; i++)
            {
                snakeElements.Enqueue(new Point(nextLeftX, nexTopY)); 
                GetNextPosition(direction, currentSnakeHead);
            }
            FoodEaten += lenght;

            CreateFood();
        }

        private int RandomFoodNumber => new Random().Next(0,foods.Count);
      

        private void CreateSnake()
        {
            for (int topY = 1; topY <= DeFaultSnakeSize; topY++)
            {
                snakeElements.Enqueue(new Point(2, topY));
            }
        }
        private void GetFoods()
        {
            foods.Add( new FoodHash(wall));
            foods.Add(new FoodAsterisk(wall));
            foods.Add(new FoodDollar(wall));
        }
        private void GetNextPosition(Point direction,Point snakeHead)
        {
            nextLeftX = snakeHead.LeftX + direction.LeftX;
            nexTopY=snakeHead.TopY + direction.TopY;

        }
        private void CreateFood()
        {
            this.foodIndex = this.RandomFoodNumber;
            this.foods[foodIndex].SetRandomPosition(snakeElements);
        }
       
    }
}
