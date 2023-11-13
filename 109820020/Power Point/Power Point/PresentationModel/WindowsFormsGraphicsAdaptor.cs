using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Power_Point
{
    class WindowsFormsGraphicsAdaptor : IGraphics
    {
        Graphics _graphics;

        public WindowsFormsGraphicsAdaptor(Graphics graphics)
        {
            this._graphics = graphics;
        }
        
        // OnPaint時會自動清除畫面，因此不需實作
        public void ClearAll()
        {
        }
        
        // 畫線
        public void DrawLine(int x1, int y1, int x2, int y2)
        {
            _graphics.DrawLine(Pens.Black, x1, y1, x2, y2);
        }
        
        // 畫矩形
        public void DrawRectangle(int x1, int y1, int x2, int y2)
        {
            if (!(x1 == x2 && y1 == y2))
                _graphics.DrawRectangle(Pens.Black, Math.Min(x1, x2), Math.Min(y1, y2), 
                    Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
        
        // 畫圓
        public void DrawCircle(int x1, int y1, int x2, int y2)
        {
            if (!(x1 == x2 && y1 == y2))
                _graphics.DrawEllipse(Pens.Black, Math.Min(x1, x2), Math.Min(y1, y2),
                    Math.Abs(x1 - x2), Math.Abs(y1 - y2));
        }
    }
}
