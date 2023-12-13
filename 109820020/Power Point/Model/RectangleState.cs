using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public class RectangleState : DrawingState
    {
        private const string STATE_NAME = "Rectangle";

        public RectangleState(Model model)
        {
            this._model = model;
            _isMouseDown = false;
            _stateName = STATE_NAME;
        }

        // MouseDown
        public override void MouseDown(int pointX, int pointY)
        {
            _isMouseDown = true;
            _hint = new Rectangle(pointX, pointY, pointX, pointY);
        }
    }
}
