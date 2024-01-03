using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Power_Point
{
    public class FormGraphicsAdapter : IGraphics
    {
        private const string RED = "Red";
        private const string BLACK = "Black";
        private const string GRAY = "Gray";
        Graphics _graphics;
        double _relativeToActualRate;

        public FormGraphicsAdapter(Graphics graphics, double relativeToActualRate)
        {
            this._graphics = graphics;
            _relativeToActualRate = relativeToActualRate;
        }
        
        // OnPaint時會自動清除畫面，因此不需實作
        public void ClearAll()
        {
        }
        
        // 畫線
        public void DrawLine(int x1, int y1, int x2, int y2, string color = RED)
        {
            Pen pen = Pens.Red;
            if (color == BLACK)
                pen = Pens.Black;
            else if (color == GRAY)
                pen = Pens.Gray;

            _graphics.DrawLine(pen, MultiplyRelativeToActualRate(x1), MultiplyRelativeToActualRate(y1),
                MultiplyRelativeToActualRate(x2), MultiplyRelativeToActualRate(y2));
        }
        
        // 畫矩形
        public void DrawRectangle(int x1, int y1, int x2, int y2, string color = RED)
        {
            Pen pen = Pens.Red;
            if (color == BLACK)
                pen = Pens.Black;
            else if (color == GRAY)
                pen = Pens.Gray;

            if (!(x1 == x2 && y1 == y2))
                _graphics.DrawRectangle(pen, MultiplyRelativeToActualRate( Math.Min(x1, x2) ),
                    MultiplyRelativeToActualRate( Math.Min(y1, y2) ),
                    MultiplyRelativeToActualRate( Math.Abs(x1 - x2) ),
                    MultiplyRelativeToActualRate(Math.Abs(y1 - y2) ));
        }
        
        // 畫圓
        public void DrawCircle(int x1, int y1, int x2, int y2, string color = RED)
        {
            Pen pen = Pens.Red;
            if (color == BLACK)
                pen = Pens.Black;
            else if (color == GRAY)
                pen = Pens.Gray;

            if (!(x1 == x2 && y1 == y2))
                _graphics.DrawEllipse(pen, MultiplyRelativeToActualRate(Math.Min(x1, x2)),
                    MultiplyRelativeToActualRate(Math.Min(y1, y2)),
                    MultiplyRelativeToActualRate(Math.Abs(x1 - x2)),
                    MultiplyRelativeToActualRate(Math.Abs(y1 - y2)));
        }

        // 乘以_relativeToActualRate
        private int MultiplyRelativeToActualRate(int multiplicand)
        {
            return Convert.ToInt32(multiplicand * _relativeToActualRate);
        }
    }
}
