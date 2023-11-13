using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public interface IShape
    {
        // GetShapeName
        string GetShapeName();

        // 取得座標
        string GetInfo();

        // 設定第二點
        void SetSecondPoint(int pointX, int pointY);

        // 畫布繪圖
        void Draw(IGraphics graphics);
    }
}
