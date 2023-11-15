using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public class PointState : IState
    {
        private const string STATE_NAME = "Pointer";
        private const string KEY_DELETE = "Delete";
        private Model _model;
        private bool _isMouseDown;
        private int _selectedIndex;

        public PointState(Model model)
        {
            this._model = model;
            this._isMouseDown = false;
            this._selectedIndex = -1;
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
            _selectedIndex = _model.SelectShape(pointX, pointY);
        }

        // MouseMove
        public void MouseMove(int pointX, int pointY)
        {
            if (_isMouseDown && _selectedIndex >= 0)
            {
                _model.MoveShape(_selectedIndex, pointX, pointY);
            }
        }

        // MouseUp
        public void MouseUp(int pointX, int pointY)
        {
            if (_isMouseDown && _selectedIndex >= 0)
            {
                _model.MoveShape(_selectedIndex, pointX, pointY);
            }
            _isMouseDown = false;
        }

        // KeyDown
        public void KeyDown(string key)
        {
            if (_selectedIndex >= 0)
            {
                if (key == KEY_DELETE)
                    _model.DeleteShape(_selectedIndex);
            }
        }

        // Draw
        public void Draw(IGraphics graphics)
        {
        }
    }
}
