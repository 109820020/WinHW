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

        public Factory() 
        { 
        }
        
        // AddShape
        public Shape AddShape(string shapeName, int x1, int y1, int x2, int y2)
        {
            if (shapeName == LINE)
                return new Line(x1, y1, x2, y2);
            else if (shapeName == RECT)
                return new Rectangle(x1, y1, x2, y2);
            else
                return new Circle(x1, y1, x2, y2);
        }
    }
}
