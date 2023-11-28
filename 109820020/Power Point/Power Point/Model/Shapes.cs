using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Power_Point
{
    class Shapes
    {
        private BindingList<Shape> _shapeList;
        private Factory _factory;

        public Shapes()
        {
            _shapeList = new BindingList<Shape>();
            _factory = new Factory();
        }

        // binding DataGridView 所需屬性
        public BindingList<Shape> ShapeList
        {
            get
            {
                return this._shapeList;
            }
        }

        // AddShape(string)
        public void AddShape(string shapeName)
        {
            _shapeList.Add(_factory.AddShape(shapeName));
        }

        // AddShape(Shape)
        public void AddShape(Shape shape)
        {
            _shapeList.Add(shape);
        }
        
        // DeleteShape
        public void DeleteShape(int index)
        {
            _shapeList.RemoveAt(index);
        }
        
        // 畫布繪圖
        public void DrawAllShapes(IGraphics graphics)
        {
            foreach (Shape shape in _shapeList)
                shape.Draw(graphics);
        }

        // 選取並回傳指標所選取最上面的形狀的index
        // 無選到任何形狀回傳-1
        public int SelectShape(int pointX, int pointY)
        {
            int index = -1;
            for (int i = 0; i < _shapeList.Count; i++)
            {
                if (_shapeList[i].IsCursorIn(pointX, pointY))
                    index = i;
                _shapeList[i].CancelSelect();
            }
            if (index >= 0)
                _shapeList[index].Select(pointX, pointY);
            return index;
        }

        // 移動形狀by位移
        public void MoveShape(int index, int offsetX, int offsetY)
        {
            _shapeList[index].MoveShape(offsetX, offsetY);
        }
    }
}
