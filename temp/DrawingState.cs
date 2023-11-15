using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public class DrawingState : IState
    {
        private const string STATE_NAME = "Line";
        private bool _isMouseDown;

        public DrawingState()
        {
            _isMouseDown = false;
        }

        // GetStateName
        public string GetStateName()
        {
            return STATE_NAME;
        }

        // MouseDown
        public void MouseDown(int pointX, int pointY)
        {
            _isMouseDown = true;

        }

        // MouseMove
        public void MouseMove(int pointX, int pointY)
        {
        }

        // MouseUp
        public void MouseUp(int pointX, int pointY)
        {
            if (_isMouseDown)
            {
                _isMouseDown = false;
                _hint.SetSecondPoint(pointX, pointY);
                _shapes.AddShape(_hint);
                NotifyModelChanged();
            }
        }
    }
}
