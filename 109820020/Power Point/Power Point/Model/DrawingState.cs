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
        private Model _model;
        private bool _isMouseDown;
        private Shape _hint;

        public DrawingState(Model model)
        {
            this._model = model;
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
            _hint = new Line(pointX, pointY, pointX, pointY);
        }

        // MouseMove
        public void MouseMove(int pointX, int pointY)
        {
            if (_isMouseDown)
            {
                _hint.ChangeSecondPoint(pointX, pointY);
            }
        }

        // MouseUp
        public void MouseUp(int pointX, int pointY)
        {
            if (_isMouseDown)
            {
                _isMouseDown = false;
                _hint.ChangeSecondPoint(pointX, pointY);
                _model.AddShape(_hint);
            }
        }

        // Draw
        public void Draw(IGraphics graphics)
        {
            if (_isMouseDown)
            {
                _hint.Draw(graphics);
            }
        }
    }
}
