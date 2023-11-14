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

        // 畫布繪圖
        abstract public void Draw(IGraphics graphics);
    }
}
