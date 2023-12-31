﻿using System;
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
        private int _x1;
        private int _y1;
        private int _x2;
        private int _y2;
        private int _shapeIndex;
        private int _pageIndex;

        public AddCommand(Model model, int pageIndex, String shapeName, int x1, int y1, int x2, int y2)
        {
            _model = model;
            _shape = null;
            _shapeName = shapeName;
            _x1 = x1;
            _y1 = y1;
            _x2 = x2;
            _y2 = y2;
            _shapeIndex = -1;
            _pageIndex = pageIndex;
        }

        // 執行
        public void Execute()
        {
            Debug.Assert(_shapeName != "");
            if (_shape == null)
                _shapeIndex = _model.AddShape(_pageIndex, _shapeName, _x1, _y1, _x2, _y2);
            // Redo的時候
            else
                _model.InsertShape(_pageIndex, _shapeIndex, _shape);
        }

        // 回復
        public void Unexecute()
        {
            Debug.Assert(_shapeIndex >= 0);
            // for Redo
            _shape = _model.GetShape(_pageIndex, _shapeIndex);
            _model.DeleteShape(_pageIndex, _shapeIndex);
        }
    }
}
