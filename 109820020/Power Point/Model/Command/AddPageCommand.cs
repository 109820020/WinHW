using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Power_Point
{
    public class AddPageCommand : ICommand
    {
        private Model _model;
        private int _pageIndex;

        public AddPageCommand(Model model, int pageIndex)
        {
            _model = model;
            _pageIndex = pageIndex;
        }

        // 執行
        public void Execute()
        {
            _model.AddPage(_pageIndex);
        }

        // 回復
        public void Unexecute()
        {
            _model.DeletePage(_pageIndex);
        }
    }
}
