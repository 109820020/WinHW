using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public class Line : Shape
    {
        private const string NAME = "線";

        // 任意兩點
        public Line(int x1, int y1, int x2, int y2)
        {
            this._name = NAME;
            this._x1 = x1;
            this._y1 = y1;
            this._x2 = x2;
            this._y2 = y2;
        }

        // 畫布繪圖
        public override void Draw(IGraphics graphics)
        {
            graphics.DrawLine(_x1, _y1, _x2, _y2);
            DrawSelectedBox(graphics);
        }
    }
}
