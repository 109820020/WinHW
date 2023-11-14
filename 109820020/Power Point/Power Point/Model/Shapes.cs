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

        // AddShape(IShape)
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
    }
}
