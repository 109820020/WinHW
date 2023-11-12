using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point
{
    class Shapes
    {
        private List<IShape> _shapeList;
        private Factory _factory;

        public Shapes()
        {
            _shapeList = new List<IShape>();
            _factory = new Factory();
        }
        
        // AddShape(string)
        public void AddShape(string shapeName)
        {
            _shapeList.Add(_factory.AddShape(shapeName));
        }

        // AddShape(IShape)
        public void AddShape(IShape shape)
        {
            _shapeList.Add(shape);
        }
        
        // DeleteShape
        public void DeleteShape(int index)
        {
            _shapeList.RemoveAt(index);
        }
        
        // 取得所有形狀的名子
        public List<string> GetAllName()
        {
            List<string> nameList = new List<string>();
            foreach (IShape shape in _shapeList)
                nameList.Add(shape.GetShapeName());
            return nameList;
        }
        
        // 取得所有形狀的資訊
        public List<string> GetAllInfo()
        {
            List<string> infoList = new List<string>();
            foreach (IShape shape in _shapeList)
                infoList.Add(shape.GetInfo());
            return infoList;
        }
        
        // 畫布繪圖
        public void Draw(IGraphics graphics)
        {
            foreach (IShape shape in _shapeList)
                shape.Draw(graphics);
        }
    }
}
