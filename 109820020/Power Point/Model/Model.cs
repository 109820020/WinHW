using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;

namespace Power_Point
{
    public class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();

        private const string LINE = "Line";
        private const string RECTANGLE = "Rectangle";
        private const string CIRCLE = "Circle";
        private const string POINTER = "Pointer";

        private Pages _pages;
        private int _currentPageIndex; 
        private IState _state;
        private PointState _pointState;
        private LineState _lineState;
        private RectangleState _rectangleState;
        private CircleState _circleState;
        private CommandManager _commandManager;

        public Model()
        {
            _pages = new Pages();
            _currentPageIndex = 0;

            _pointState = new PointState(this);
            _lineState = new LineState(this);
            _rectangleState = new RectangleState(this);
            _circleState = new CircleState(this);
            // 預設 Point State
            _state = _pointState;
            _commandManager = new CommandManager();
        }

        // binding DataGridView 所需屬性
        public BindingList<Shape> Shapes
        {
            get
            {
                return _pages.BindingShapes;
            }
        }

        // for IState 做 Undo Redo
        public CommandManager CommandManager
        {
            get
            {
                return _commandManager;
            }
        }

        // GetCurrentPageIndex
        public int GetCurrentPageIndex()
        {
            return _currentPageIndex;
        }

        // 取得頁面數量
        public int GetNumPages()
        {
            return _pages.GetNumPages();
        }

        // 增加頁面
        public void AddPage()
        {
            _pages.AddPage(++_currentPageIndex);
            NotifyModelChanged();
        }

        // 切換頁面
        public void SwitchPage(int index)
        {
            _currentPageIndex = index;
            // 切換 BindingShapes
            _pages.SwitchBindingShapes(index);
        }

        // 新增隨機形狀到 CmdManager
        public void AddShapeToCommandManager(string shapeName)
        {
            _commandManager.Execute(new AddCommand(this, _currentPageIndex, shapeName));
        }

        // 新增隨機形狀 回傳形狀index
        public int AddShape(int pageIndex, string shapeName)
        {
            int index = _pages.AddShape(pageIndex, shapeName);
            NotifyModelChanged();
            return index;
        }

        // 新增形狀 回傳形狀index
        public int AddShape(int pageIndex, Shape shape)
        {
            int index = _pages.AddShape(pageIndex, shape);
            NotifyModelChanged();
            return index;
        }

        // 刪除形狀
        public void DeleteShape(int pageIndex, int index)
        {
            _pages.DeleteShape(pageIndex, index);
            NotifyModelChanged();
        }

        // 刪除形狀
        public void DeleteShapeToCommandManager(int index)
        {
            _commandManager.Execute(new DeleteCommand(this, _currentPageIndex, index));
        }

        // ChangeState
        public void ChangeState(string shapeType)
        {
            if (shapeType == POINTER)
            {
                _state = _pointState;
            }
            else if (shapeType == LINE)
            {
                _state = _lineState;
            }
            else if (shapeType == RECTANGLE)
            {
                _state = _rectangleState;
            }
            else if (shapeType == CIRCLE)
            {
                _state = _circleState;
            }
        }

        // 取得工具列狀態
        public string GetToolState()
        {
            return _state.GetStateName();
        }

        // IsUndoEnabled
        public bool IsUndoEnabled()
        {
            return _commandManager.IsUndoEnabled();
        }

        // IsRedoEnabled
        public bool IsRedoEnabled()
        {
            return _commandManager.IsRedoEnabled();
        }

        // Undo
        public void Undo()
        {
            _commandManager.Undo();
        }

        // Redo
        public void Redo()
        {
            _commandManager.Redo();
        }

        // 選取並回傳指標所選取最上面的形狀的index
        // 無選到任何形狀回傳-1
        public int SelectShape(int pointX, int pointY)
        {
            return _pages.SelectShape(_currentPageIndex, pointX, pointY);
        }

        // 取得形狀
        public Shape GetShape(int pageIndex, int index)
        {
            return _pages.GetShape(pageIndex, index);
        }

        // 插入形狀
        public void InsertShape(int pageIndex, int index, Shape shape)
        {
            _pages.InsertShape(pageIndex, index, shape);
            NotifyModelChanged();
        }

        // 移動形狀by位移
        public void MoveShape(int index, int offsetX, int offsetY)
        {
            _pages.MoveShape(_currentPageIndex, index, offsetX, offsetY);
        }

        // KeyDown
        public void KeyDown(string key)
        {
            _state.KeyDown(key);
            NotifyModelChanged();
        }

        // 在畫布中按下左鍵
        public void CanvasPressed(int pointX, int pointY)
        {
            _state.MouseDown(pointX, pointY);
        }

        // 在畫布中移動
        public void CanvasMoved(int pointX, int pointY)
        {
            _state.MouseMove(pointX, pointY);
            NotifyModelChanged();
        }

        // 在畫布中放開左鍵
        public void CanvasReleased(int pointX, int pointY)
        {
            _state.MouseUp(pointX, pointY);
            _state = _pointState;
            NotifyModelChanged();
        }
        
        // 畫布繪圖(當前頁面)
        public void Draw(IGraphics graphics)
        {
            graphics.ClearAll();
            _pages.DrawShapes(_currentPageIndex, graphics);
            _state.Draw(graphics);
        }

        // 畫布繪圖(By index)
        public void Draw(int pageIndex, IGraphics graphics)
        {
            graphics.ClearAll();
            _pages.DrawShapes(pageIndex, graphics);
        }

        // Model改變事件
        private void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
    }
}
