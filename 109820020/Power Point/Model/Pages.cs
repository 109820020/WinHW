using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace Power_Point
{
    public class Pages
    {
        private List<Shapes> _pages;
        private BindingList<Shape> _bindingShapes;

        public Pages()
        {
            _pages = new List<Shapes>();
            _pages.Add(new Shapes());
            _bindingShapes = new BindingList<Shape>();
        }

        // 增加頁面
        public void AddPage(int pageIndex)
        {
            _pages.Insert(pageIndex, new Shapes());
        }

        // 取得頁面數量
        public int GetNumPages()
        {
            return _pages.Count();
        }

        // 取得Shapes for DataGridView databinding
        public BindingList<Shape> BindingShapes
        {
            get
            {
                return _bindingShapes;
            }
        }

        // 切換 BindingShapes
        public void SwitchBindingShapes(int index)
        {
            _bindingShapes.Clear();
            foreach (Shape shape in _pages[index].ShapeList)
            {
                _bindingShapes.Add(shape);
            }
        }

        // 新增形狀 回傳形狀index
        public int AddShape(int pageIndex, string shapeName)
        {
            return _pages[pageIndex].AddShape(shapeName);
        }

        // 新增形狀 回傳形狀index
        public int AddShape(int pageIndex, Shape shape)
        {
            return _pages[pageIndex].AddShape(shape);
        }

        // 刪除形狀
        public void DeleteShape(int pageIndex, int index)
        {
            _pages[pageIndex].DeleteShape(index);
        }

        // 選取並回傳指標所選取最上面的形狀的index
        // 無選到任何形狀回傳-1
        public int SelectShape(int pageIndex, int pointX, int pointY)
        {
            return _pages[pageIndex].SelectShape(pointX, pointY);
        }

        // 取得形狀
        public Shape GetShape(int pageIndex, int index)
        {
            return _pages[pageIndex].GetShape(index);
        }

        // 插入形狀
        public void InsertShape(int pageIndex, int index, Shape shape)
        {
            _pages[pageIndex].InsertShape(shape, index);
        }

        // 移動形狀by位移
        public void MoveShape(int pageIndex, int index, int offsetX, int offsetY)
        {
            _pages[pageIndex].MoveShape(index, offsetX, offsetY);
        }

        // 畫布繪圖
        public void DrawShapes(int pageIndex, IGraphics graphics)
        {
            _pages[pageIndex].DrawAllShapes(graphics);
        }
    }
}
