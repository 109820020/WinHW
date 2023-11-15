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

        private Shapes _shapes;
        private IState _state;
        private PointState _pointState;
        private LineState _lineState;
        private RectangleState _rectangleState;
        private CircleState _circleState;

        public Model()
        {
            _shapes = new Shapes();

            _pointState = new PointState(this);
            _lineState = new LineState(this);
            _rectangleState = new RectangleState(this);
            _circleState = new CircleState(this);
            // 預設 Point State
            _state = _pointState;
        }

        // binding DataGridView 所需屬性
        public BindingList<Shape> Shapes
        {
            get
            {
                return _shapes.ShapeList;
            }
        }

        // 新增隨機形狀
        public void AddShape(string shapeName)
        {
            _shapes.AddShape(shapeName);
            NotifyModelChanged();
        }

        // 新增形狀
        public void AddShape(Shape shape)
        {
            _shapes.AddShape(shape);
            NotifyModelChanged();
        }

        // 刪除形狀
        public void DeleteShape(int index)
        {
            _shapes.DeleteShape(index);
            NotifyModelChanged();
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

        // 選取並回傳指標所選取最上面的形狀的index
        // 無選到任何形狀回傳-1
        public int SelectShape(int pointX, int pointY)
        {
            return _shapes.SelectShape(pointX, pointY);
        }

        // 移動形狀by位移
        public void MoveShape(int index, int offsetX, int offsetY)
        {
            _shapes.MoveShape(index, offsetX, offsetY);
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
        
        // 畫布繪圖
        public void Draw(IGraphics graphics)
        {
            graphics.ClearAll();
            _shapes.DrawAllShapes(graphics);
            _state.Draw(graphics);
        }
        
        // Model改變事件
        private void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
    }
}
