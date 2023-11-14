﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    abstract public class DrawingState : IState
    {
        protected Model _model;
        protected bool _isMouseDown;
        protected Shape _hint;
        protected string _stateName;

        // GetStateName
        public string GetStateName()
        {
            return _stateName;
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

        // MouseDown
        abstract public void MouseDown(int pointX, int pointY);
    }
}
