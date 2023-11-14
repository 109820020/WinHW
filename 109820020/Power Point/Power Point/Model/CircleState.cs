using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public class CircleState : DrawingState
    {
        private const string STATE_NAME = "Circle";

        public CircleState(Model model)
        {
            this._model = model;
            _isMouseDown = false;
            _stateName = STATE_NAME;
        }

        // MouseDown
        public override void MouseDown(int pointX, int pointY)
        {
            _isMouseDown = true;
            _hint = new Circle(pointX, pointY, pointX, pointY);
        }
    }
}
