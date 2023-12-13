using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Power_Point
{
    public class DeleteCommand : ICommand
    {
        private Model _model;
        private Shape _shape;
        private int _shapeIndex;

        public DeleteCommand(Model model, int index)
        {
            _model = model;
            _shape = null;
            _shapeIndex = index;
        }

        // 執行
        public void Execute()
        {
            Debug.Assert(_shapeIndex >= 0);
            _shape = _model.GetShape(_shapeIndex);
            Debug.Assert(_shape != null);
            _model.DeleteShape(_shapeIndex);
        }

        // 回復
        public void Unexecute()
        {
            Debug.Assert(_shape != null);
            _model.InsertShape(_shape, _shapeIndex);
        }
    }
}
