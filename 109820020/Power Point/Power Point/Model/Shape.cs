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
        public string _name;
        public int _x1, _y1, _x2, _y2;

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
            return "(" + x1 + ", " + y1 + ")," + "(" + x2 + ", " + y2 + ")";
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
        abstract public void SetSecondPoint(int pointX, int pointY);

        // 畫布繪圖
        abstract public void Draw(IGraphics graphics);
    }
}
