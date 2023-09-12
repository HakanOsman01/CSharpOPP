using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleSnake.GameObjects
{
    public class Wall : Point
    {
        private const char WallSymbol = '\u25A0';
        public Wall(int leftX, int topY) 
            : base(leftX, topY)
        {
            InitialiseBorders();
        }
        private void InitialiseBorders()
        {
            SetHorizontalLine(0);
            SetHorizontalLine(TopY);

            SetVerticalLineLine(0);
            SetVerticalLineLine(LeftX - 1);
        }
        public bool IsPointOfWall(Point snakeHead) => snakeHead.TopY == 0
         || snakeHead.LeftX == 0 ||
            snakeHead.LeftX == this.LeftX - 1
            || snakeHead.TopY == this.TopY;
       
        private void SetHorizontalLine(int topY)
        {
            for (int leftX = 0; leftX < this.LeftX; leftX++)
            {
                Draw(leftX, topY, WallSymbol);
            }
        }
        private void SetVerticalLineLine(int leftX)
        {
            for (int topY = 0; topY < this.TopY; topY++)
            {
                Draw(leftX, topY, WallSymbol);
            }
        }

    }
}
