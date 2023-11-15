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
        private Model _model;
        private bool _isMouseDown;
        private int _selectedIndex;
        private int _mouseDownPointX = 0;
        private int _mouseDownPointY = 0;

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
            _mouseDownPointX = pointX;
            _mouseDownPointY = pointY;
            _selectedIndex = _model.SelectShape(pointX, pointY);
        }

        // MouseMove
        public void MouseMove(int pointX, int pointY)
        {
            //if (_isMouseDown && _selectedIndex >= 0)
            //{
            //    _model.MoveShapeTo(pointX - _mouseDownPointX, pointY - _mouseDownPointY);
            //}
        }

        // MouseUp
        public void MouseUp(int pointX, int pointY)
        {
            //if (_isMouseDown && _selectedIndex >= 0)
            //{
            //    _model.MoveShapeTo(pointX - _mouseDownPointX, pointY - _mouseDownPointY);
            //}
            //_isMouseDown = true;
            //_mouseDownPointX = pointX;
            //_mouseDownPointY = pointY;
            //_selectedIndex = _model.SelectShape(pointX, pointY);
            _isMouseDown = false;
        }

        // Draw
        public void Draw(IGraphics graphics)
        {
        }
    }
}
