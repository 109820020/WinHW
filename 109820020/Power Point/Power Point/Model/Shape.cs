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
        protected string _name;
        protected bool _isSelect = false;
        protected int _x1;
        protected int _y1;
        protected int _x2;
        protected int _y2;

        // GetShapeName
        string GetShapeName()
        {
            return _name;
        }

        // 取得座標
        string GetInfo()
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
        void NotifyPropertyChanged(string propertyName)
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
        public bool isCursorIn(int pointX, int pointY)
        {
            int x1 = Math.Min(_x1, _x2);
            int y1 = Math.Min(_y1, _y2);
            int x2 = Math.Max(_x1, _x2);
            int y2 = Math.Max(_y1, _y2);
            return pointX >= x1 && pointX <= x2 && pointY >= y1 && pointY <= y2;
        }

        // 選取
        public void Select()
        {
            _isSelect = true;
        }

        // 取消選取
        public void UnSelect()
        {
            _isSelect = false;
        }

        // 選取外框繪圖
        public void DrawSelectedBox(IGraphics graphics)
        {
            if (_isSelect)
            {
                // 外框
                graphics.DrawRectangle(_x1, _y1, _x2, _y2, "Gray");
                // 圓圈
                int radius = 3;
                graphics.DrawCircle(_x1 - radius, _y1 - radius, _x1 + radius, _y1 + radius, "Black");
                graphics.DrawCircle(_x1 - radius, _y2 - radius, _x1 + radius, _y2 + radius, "Black");
                graphics.DrawCircle(_x2 - radius, _y1 - radius, _x2 + radius, _y1 + radius, "Black");
                graphics.DrawCircle(_x2 - radius, _y2 - radius, _x2 + radius, _y2 + radius, "Black");

                int middleX = (_x1 + _x2) / 2;
                int middleY = (_y1 + _y2) / 2;
                graphics.DrawCircle(_x1 - radius, middleY - radius, _x1 + radius, middleY + radius, "Black");
                graphics.DrawCircle(middleX - radius, _y1 - radius, middleX + radius, _y1 + radius, "Black");
                graphics.DrawCircle(middleX - radius, _y2 - radius, middleX + radius, _y2 + radius, "Black");
                graphics.DrawCircle(_x2 - radius, middleY - radius, _x2 + radius, middleY + radius, "Black");
            }
        }

        // 移動形狀by位移
        public void MoveShape(int offsetX, int offsetY)
        {
            _x1 += offsetX;
            _x2 += offsetX;
            _y1 += offsetY;
            _y2 += offsetY;
            NotifyPropertyChanged("Info");
        }

        // 畫布繪圖
        abstract public void Draw(IGraphics graphics);
    }
}
