using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public interface ICommand
    {
        // 執行
        void Execute();

        // 回復
        void Unexecute();
    }
}
