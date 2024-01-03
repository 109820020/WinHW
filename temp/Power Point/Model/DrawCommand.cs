using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Power_Point
{
    public class DrawCommand : ICommand
    {
        private Model _model;
        private Shape _shape;
        private int _shapeIndex;

        public DrawCommand(Model model, Shape shape)
        {
            _model = model;
            _shape = shape;
            _shapeIndex = -1;
        }

        // 執行
        public void Execute()
        {
            Debug.Assert(_shape != null);
            _shapeIndex = _model.AddShape(_shape);
        }

        // 回復
        public void Unexecute()
        {
            Debug.Assert(_shapeIndex >= 0);
            _model.DeleteShape(_shapeIndex);
        }
    }
}
