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
        private Shapes _shapes;
        private bool _isCanvasPressed;
        private Shape _hint;

        public Model()
        {
            _shapes = new Shapes();
            _isCanvasPressed = false;
        }

        // binding DataGridView 所需屬性
        public BindingList<Shape> Shapes
        {
            get
            {
                return _shapes.ShapeList;
            }
        }

        // 新增形狀
        public void AddShape(string shapeName)
        {
            _shapes.AddShape(shapeName);
            NotifyModelChanged();
        }
        
        // 刪除形狀
        public void DeleteShape(int index)
        {
            _shapes.DeleteShape(index);
            NotifyModelChanged();
        }

        // 在畫布中按下左鍵
        public void CanvasPressed(Shape hint)
        {
            _hint = hint;
            _isCanvasPressed = true;
        }

        // 在畫布中放開左鍵
        public void CanvasReleased(int pointX, int pointY)
        {
            if (_isCanvasPressed)
            {
                _isCanvasPressed = false;
                _hint.SetSecondPoint(pointX, pointY);
                _shapes.AddShape(_hint);
                NotifyModelChanged();
            }
        }

        // 在畫布中移動
        public void CanvasMoved(int pointX, int pointY)
        {
            if (_isCanvasPressed)
            {
                _hint.SetSecondPoint(pointX, pointY);
                NotifyModelChanged();
            }
        }
        
        // 畫布繪圖
        public void Draw(IGraphics graphics)
        {
            _shapes.DrawAllShapes(graphics);
            if (_isCanvasPressed)
                _hint.Draw(graphics);
        }
        
        // Model改變事件
        private void NotifyModelChanged()
        {
            if (_modelChanged != null)
                _modelChanged();
        }
    }
}
