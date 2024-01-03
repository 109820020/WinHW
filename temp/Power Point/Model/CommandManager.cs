using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Diagnostics;

namespace Power_Point
{
    public class CommandManager
    {
        private Stack<ICommand> _undo;
        private Stack<ICommand> _redo;

        public CommandManager()
        {
            _undo = new Stack<ICommand>();
            _redo = new Stack<ICommand>();
        }

        // 執行
        public void Execute(ICommand command)
        {
            command.Execute();
            _undo.Push(command);
            _redo.Clear();
        }

        // 回復
        public void Undo()
        {
            Debug.Assert(_undo.Count > 0);
            ICommand command = _undo.Pop();
            _redo.Push(command);
            command.Unexecute();
        }

        // 再執行
        public void Redo()
        {
            Debug.Assert(_redo.Count > 0);
            ICommand command = _redo.Pop();
            _undo.Push(command);
            command.Execute();
        }

        // IsRedoEnabled
        public bool IsRedoEnabled()
        {
            return _redo.Count != 0;
        }

        // IsUndoEnabled
        public bool IsUndoEnabled()
        {
            return _undo.Count != 0;
        }
    }
}
