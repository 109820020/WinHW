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
        private int _pageIndex;

        public DeleteCommand(Model model, int pageIndex, int index)
        {
            _model = model;
            _shape = null;
            _shapeIndex = index;
            _pageIndex = pageIndex;
        }

        // 執行
        public void Execute()
        {
            Debug.Assert(_shapeIndex >= 0);
            _shape = _model.GetShape(_pageIndex, _shapeIndex);
            Debug.Assert(_shape != null);
            _model.DeleteShape(_pageIndex, _shapeIndex);
        }

        // 回復
        public void Unexecute()
        {
            Debug.Assert(_shape != null);
            _model.InsertShape(_pageIndex, _shapeIndex, _shape);
        }
    }
}
