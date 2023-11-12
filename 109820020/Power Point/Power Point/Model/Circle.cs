using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    class Circle : IShape
    {
        private const string NAME = "圓";
        private int _x1, _y1, _x2, _y2;
        
        // 輸入任意對角點
        public Circle(int x1, int y1, int x2, int y2)
        {
            this._x1 = x1;
            this._y1 = y1;
            this._x2 = x2;
            this._y2 = y2;
        }
        
        // GetShapeName
        string IShape.GetShapeName()
        {
            return NAME;
        }
        
        // GetInfo, return e.g. "(100, 200),(120, 300)"
        string IShape.GetInfo()
        {
            int x1 = Math.Min(_x1, _x2);
            int y1 = Math.Min(_y1, _y2);
            int x2 = Math.Max(_x1, _x2);
            int y2 = Math.Max(_y1, _y2);
            return $"({x1}, {y1}),({x2}, {y2})";
        }

        // 設定第二點
        void IShape.SetSecondPoint(int x, int y)
        {
            this._x2 = x;
            this._y2 = y;
        }

        // 畫布繪圖
        void IShape.Draw(IGraphics graphics)
        {
            graphics.DrawCircle(_x1, _y1, _x2, _y2);
        }
    }
}
