using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public interface IState
    {
        // GetStateName
        string GetStateName();

        // MouseDown
        void MouseDown(int pointX, int pointY);

        // MouseMove
        void MouseMove(int pointX, int pointY);

        // MouseUp
        void MouseUp(int pointX, int pointY);

        // KeyDown
        void KeyDown(string key);

        // Draw
        void Draw(IGraphics graphics);
    }
}
