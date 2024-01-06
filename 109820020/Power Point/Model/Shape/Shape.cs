using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Power_Point
{
    abstract public class Shape : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private const string LEFT_PARENTHESIS = "(";
        private const string RIGHT_PARENTHESIS = ")";
        private const string COMMA = ", ";
        private const string BLACK = "Black";
        private const string GRAY = "Gray";
        private const string INFO = "Info";
        private const int TWO = 2;
        private const int THREE = 3;
        private const int FIVE = 5;
        protected string _name;
        protected bool _isSelect = false;
        protected int _x1;
        protected int _y1;
        protected int _x2;
        protected int _y2;
        protected int _pressedDownPointX = 0;
        protected int _pressedDownPointY = 0;
        protected int _beforeMovingPointX1 = 0;
        protected int _beforeMovingPointY1 = 0;
        protected int _beforeMovingPointX2 = 0;
        protected int _beforeMovingPointY2 = 0;

        // GetShapeName
        public string GetShapeName()
        {
            return _name;
        }

        // 取得座標
        public string GetInfo()
        {
            int x1 = Math.Min(_x1, _x2);
            int y1 = Math.Min(_y1, _y2);
            int x2 = Math.Max(_x1, _x2);
            int y2 = Math.Max(_y1, _y2);
            return LEFT_PARENTHESIS + x1 + COMMA + y1 + RIGHT_PARENTHESIS + COMMA + LEFT_PARENTHESIS + 
                x2 + COMMA + y2 + RIGHT_PARENTHESIS;
        }

        // binding DataGridView 所需屬性
        public string Name
        {
            get
            {
                return _name;
            }
        }

        // binding DataGridView 所需屬性
        public string Info
        {
            get
            {
                return GetInfo();
            }
        }

        // binding DataGridView 所需
        private void NotifyPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        // 設定第二點
        public void ChangeSecondPoint(int pointX, int pointY)
        {
            this._x2 = pointX;
            this._y2 = pointY;
        }

        // 指標是否在此圖形裡
        public bool IsCursorIn(int pointX, int pointY)
        {
            int x1 = Math.Min(_x1, _x2);
            int y1 = Math.Min(_y1, _y2);
            int x2 = Math.Max(_x1, _x2);
            int y2 = Math.Max(_y1, _y2);
            return pointX >= x1 && pointX <= x2 && pointY >= y1 && pointY <= y2;
        }

        // 選取
        public void Select(int pointX, int pointY)
        {
            _isSelect = true;
            _pressedDownPointX = pointX;
            _pressedDownPointY = pointY;
            _beforeMovingPointX1 = _x1;
            _beforeMovingPointY1 = _y1;
            _beforeMovingPointX2 = _x2;
            _beforeMovingPointY2 = _y2;
        }

        // 移動形狀
        public void MoveShape(int pointX, int pointY)
        {
            int offsetX = pointX - _pressedDownPointX;
            int offsetY = pointY - _pressedDownPointY;
            _x1 = _beforeMovingPointX1 + offsetX;
            _x2 = _beforeMovingPointX2 + offsetX;
            _y1 = _beforeMovingPointY1 + offsetY;
            _y2 = _beforeMovingPointY2 + offsetY;
            NotifyPropertyChanged(INFO);
        }

        // 取消選取
        public void CancelSelect()
        {
            _isSelect = false;
        }

        // 選取外框繪圖
        public void DrawSelectedBox(IGraphics graphics)
        {
            if (_isSelect)
            {
                graphics.DrawRectangle(_x1, _y1, _x2, _y2, GRAY);
                DrawSelectedBoxCircle(graphics);
            }
        }

        // 選取外框圓圈繪圖
        private void DrawSelectedBoxCircle(IGraphics graphics)
        {
            int radius = FIVE;
            graphics.DrawCircle(_x1 - radius, _y1 - radius, _x1 + radius, _y1 + radius, BLACK);
            graphics.DrawCircle(_x1 - radius, _y2 - radius, _x1 + radius, _y2 + radius, BLACK);
            graphics.DrawCircle(_x2 - radius, _y1 - radius, _x2 + radius, _y1 + radius, BLACK);
            graphics.DrawCircle(_x2 - radius, _y2 - radius, _x2 + radius, _y2 + radius, BLACK);

            int middleX = (_x1 + _x2) / TWO;
            int middleY = (_y1 + _y2) / TWO;
            graphics.DrawCircle(_x1 - radius, middleY - radius, _x1 + radius, middleY + radius, BLACK);
            graphics.DrawCircle(middleX - radius, _y1 - radius, middleX + radius, _y1 + radius, BLACK);
            graphics.DrawCircle(middleX - radius, _y2 - radius, middleX + radius, _y2 + radius, BLACK);
            graphics.DrawCircle(_x2 - radius, middleY - radius, _x2 + radius, middleY + radius, BLACK);
        }

        // 畫布繪圖
        abstract public void Draw(IGraphics graphics);
    }
}
