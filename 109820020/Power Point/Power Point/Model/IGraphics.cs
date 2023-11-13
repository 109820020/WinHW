using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public interface IGraphics
    {
        // OnPaint清除
        void ClearAll();

        // 畫線，(x1, y1), (x2, y2)為不相等任意兩點
        void DrawLine(int x1, int y1, int x2, int y2);

        // 畫矩形，(x1, y1), (x2, y2)為不相等任意兩點
        void DrawRectangle(int x1, int y1, int x2, int y2);

        // 畫圓，(x1, y1), (x2, y2)為不相等任意兩點
        void DrawCircle(int x1, int y1, int x2, int y2);
    }
}
