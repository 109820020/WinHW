using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Power_Point
{
    public class DeletePageCommand : ICommand
    {
        private Model _model;
        private int _pageIndex;
        private Shapes _shapes;

        public DeletePageCommand(Model model, int pageIndex)
        {
            _model = model;
            _pageIndex = pageIndex;
        }

        // 執行
        public void Execute()
        {
            _shapes = _model.GetPage(_pageIndex);
            _model.DeletePage(_pageIndex);
        }

        // 回復
        public void Unexecute()
        {
            _model.AddPage(_pageIndex, _shapes);
        }
    }
}
