using SimpleSnake.Core.Interfaces;
using SimpleSnake.Enums;
using SimpleSnake.GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SimpleSnake.Core
{
    public class Engine : IEngine
    {
        private Point[] pointsOfDirection;
        private Direction direction;
        private Snake snake;
        private Wall wall;
        private double sleepTime;
        public Engine(Wall wall,Snake snake)
        { 
            this.wall = wall;
            this.snake = snake;
            this.sleepTime = 100;
            pointsOfDirection = new Point[4];
        }
        public void Run()
        {
            this.CreateDirection();
            while (true)
            {
                ShowScore();
                if (Console.KeyAvailable)
                {
                    this.GetNextDirection();
                }
                bool isMoving = snake.IsMoving(pointsOfDirection[(int)direction]);
                if (!isMoving)
                {
                    AskUserForRestart();
                }
                sleepTime -= 0.000000001;
                Thread.Sleep((int)sleepTime);
            }
           
        }

        private void AskUserForRestart()
        {
            int leftX = wall.LeftX + 1;
            int topY = 3;
            Console.SetCursorPosition(leftX,topY);
            Console.Write("Woud you like to continue? y/n");
            string input = Console.ReadLine();
            if (input == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(20, 10);
            Console.Write("Game over!");
            Environment.Exit(0);

        }

        private void CreateDirection()
        {
            this.pointsOfDirection[0] = new Point(1, 0);
            this.pointsOfDirection[1] = new Point(-1, 0);
            this.pointsOfDirection[2] = new Point(0, 1);
            this.pointsOfDirection[3] = new Point(0, -1);
        }
        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput= Console.ReadKey();
            if(userInput.Key == ConsoleKey.LeftArrow)
            {
                if (direction != Direction.Right)
                {
                    direction= Direction.Left;
                }
            }
            else if (userInput.Key == ConsoleKey.RightArrow)
            {
                if (direction != Direction.Left)
                {
                    direction = Direction.Right;
                }
            }
            else if (userInput.Key == ConsoleKey.UpArrow)
            {
                if (direction != Direction.Down)
                {
                    direction = Direction.Up;
                }
            }
            else if (userInput.Key == ConsoleKey.DownArrow)
            {
                if (direction != Direction.Up)
                {
                    direction = Direction.Down;
                }
            }
            Console.CursorVisible=false;
        }
        private void ShowScore()
        {
            Console.SetCursorPosition(wall.LeftX + 1, 0);
            Console.Write($"Score: {snake.FoodEaten}");
            Console.CursorVisible = false;


        }
    }
}
