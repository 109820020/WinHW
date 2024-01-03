using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public class Factory
    {
        private const string LINE = "線";
        private const string RECT = "矩形";
        private const string CIRCLE = "圓";
        private const int CANVAS_LEFT = 0;
        private const int CANVAS_RIGHT = 882;
        private const int CANVAS_UP = 0;
        private const int CANVAS_BOTTOM = 668;

        public Factory() 
        { 
        }
        
        // AddShape
        public Shape AddShape(string shapeName)
        {
            Random random = new Random();
            (int _x, int _y)  _topLeft = (random.Next(CANVAS_LEFT, CANVAS_RIGHT), random.Next(CANVAS_UP, CANVAS_BOTTOM));
            (int _x, int _y)  _bottomRight = (random.Next(_topLeft._x, CANVAS_RIGHT), random.Next(_topLeft._y, CANVAS_BOTTOM));
            if (shapeName == LINE)
            {
                return new Line(_topLeft._x, _topLeft._y, _bottomRight._x, _bottomRight._y);
            }
            else if (shapeName == RECT)
            {
                return new Rectangle(_topLeft._x, _topLeft._y, _bottomRight._x, _bottomRight._y);
            }
            else
            {
                int width = random.Next(0, Math.Min(CANVAS_RIGHT - _topLeft._x, CANVAS_BOTTOM - _topLeft._y));
                return new Circle(_topLeft._x, _topLeft._y, _topLeft._x + width, _topLeft._y + width);
            }
        }
    }
}
