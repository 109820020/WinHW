using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Power_Point
{
    public class AddCommand : ICommand
    {
        private Model _model;
        private Shape _shape;
        private String _shapeName;
        private int _shapeIndex;

        public AddCommand(Model model, String shapeName)
        {
            _model = model;
            _shape = null;
            _shapeName = shapeName;
            _shapeIndex = -1;
        }

        // 執行
        public void Execute()
        {
            Debug.Assert(_shapeName != "");
            if (_shape == null)
                _shapeIndex = _model.AddShape(_shapeName);
            else
                _model.InsertShape(_shape, _shapeIndex);
        }

        // 回復
        public void Unexecute()
        {
            Debug.Assert(_shapeIndex >= 0);
            _shape = _model.GetShape(_shapeIndex);
            _model.DeleteShape(_shapeIndex);
        }
    }
}
