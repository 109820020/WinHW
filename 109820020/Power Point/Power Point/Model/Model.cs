using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    public class Model
    {
        public event ModelChangedEventHandler _modelChanged;
        public delegate void ModelChangedEventHandler();
        private Shapes _shapes;
        private bool _isCanvasPressed;
        private IShape _hint;

        public Model()
        {
            _shapes = new Shapes();
            _isCanvasPressed = false;
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
        
        // 取得DataGridView裡所有rows的形狀類別
        public List<string> GetAllshapeName()
        {
            return _shapes.GetAllName();
        }
        
        // 取得DataGridView裡所有rows的形狀資訊
        public List<string> GetAllShapeInfo()
        {
            return _shapes.GetAllInfo();
        }

        // 在畫布中按下左鍵
        public void CanvasPressed(IShape hint)
        {
            _hint = hint;
            _isCanvasPressed = true;
        }

        // 在畫布中放開左鍵
        public void CanvasReleased(int x, int y)
        {
            if (_isCanvasPressed)
            {
                _isCanvasPressed = false;
                _hint.SetSecondPoint(x, y);
                _shapes.AddShape(_hint);
                NotifyModelChanged();
            }
        }

        // 在畫布中移動
        public void CanvasMoved(int x, int y)
        {
            if (_isCanvasPressed)
            {
                _hint.SetSecondPoint(x, y);
                NotifyModelChanged();
            }
        }
        
        // 畫布繪圖
        public void Draw(IGraphics graphics)
        {
            _shapes.Draw(graphics);
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
