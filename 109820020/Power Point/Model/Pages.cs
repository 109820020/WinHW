using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.IO;

namespace Power_Point
{
    public class Pages
    {
        private List<Shapes> _pages;

        public Pages()
        {
            _pages = new List<Shapes>();
            _pages.Add(new Shapes());
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

        // 刪除頁面
        public void DeletePage(int pageIndex)
        {
            _pages.RemoveAt(pageIndex);
        }

        // 取得Shapes for DataGridView databinding
        public BindingList<Shape> BindingShapes(int pageIndex)
        {
                return _pages[pageIndex].ShapeList;
        }

        // 新增形狀 回傳形狀index
        public int AddShape(int pageIndex, string shapeName, int x1, int y1, int x2, int y2)
        {
            return _pages[pageIndex].AddShape(shapeName, x1, y1, x2, y2);
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

        // 清除所有形狀
        public void ClearShapes(int pageIndex)
        {
            _pages[pageIndex].ClearShapes();
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

        // 寫入pages
        public void SaveShapes(StreamWriter streamWriter)
        {
            streamWriter.WriteLine(_pages.Count.ToString());
            foreach (Shapes shapes in _pages)
            {
                shapes.SaveShape(streamWriter);
            }
        }

        // 讀入pages
        public void LoadPages(StreamReader streamReader)
        {
            _pages.Clear();
            int numPages = int.Parse(streamReader.ReadLine());
            for (int i=0; i < numPages; i++)
            {
                Shapes shapes = new Shapes();
                shapes.LoadShape(streamReader);
                _pages.Add(shapes);
            }
        }
    }
}
