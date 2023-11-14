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

        public PointState(Model model)
        {
            this._model = model;
        }

        // GetStateName
        public string GetStateName()
        {
            return STATE_NAME;
        }

        // MouseDown
        public void MouseDown(int pointX, int pointY)
        {
        }

        // MouseMove
        public void MouseMove(int pointX, int pointY)
        {
        }

        // MouseUp
        public void MouseUp(int pointX, int pointY)
        {
        }

        // Draw
        public void Draw(IGraphics graphics)
        {
        }
    }
}
