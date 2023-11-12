using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Point
{
    public class FormPresentationModel
    {
        enum ShapeTool
        {
            None,
            Line,
            Rectangle,
            Circle
        }

        private const string LINE = "Line";
        private const string RECTANGLE = "Rect";
        private const string CIRCLE = "Circle";
        private ShapeTool _shapeTool;
        private Model _model;

        public FormPresentationModel(Model model)
        {
            this._model = model;
            _shapeTool = ShapeTool.None;
        }
        
        // 工具列按鈕被按下
        public void ToolBarClick(string shapeType)
        {
            if (shapeType == LINE)
            {
                if (_shapeTool == ShapeTool.Line)
                    _shapeTool = ShapeTool.None;
                else
                    _shapeTool = ShapeTool.Line;
            }
            else if (shapeType == RECTANGLE)
            {
                if (_shapeTool == ShapeTool.Rectangle)
                    _shapeTool = ShapeTool.None;
                else
                    _shapeTool = ShapeTool.Rectangle;
            }
            else if (shapeType == CIRCLE)
            {
                if (_shapeTool == ShapeTool.Circle)
                    _shapeTool = ShapeTool.None;
                else
                    _shapeTool = ShapeTool.Circle;
            }
        }
        
        // 工具列線是否按下
        public bool IsToolLineChecked()
        {
            return _shapeTool == ShapeTool.Line;
        }
        
        // 工具列矩形是否按下
        public bool IsToolRectangleChecked()
        {
            return _shapeTool == ShapeTool.Rectangle;
        }
        
        // 工具列圓是否按下
        public bool IsToolCircleChecked()
        {
            return _shapeTool == ShapeTool.Circle;
        }
        
        // 取得游標類型
        public Cursor GetCursorType()
        {
            return _shapeTool == ShapeTool.None ? Cursors.Default : Cursors.Cross;
        }

        //  在畫布中按下左鍵
        public void CanvasPressed(int x, int y)
        {
            if (_shapeTool == ShapeTool.Line)
            {
                IShape hint = new Line(x, y, x, y);
                _model.CanvasPressed(hint);
            }
            else if (_shapeTool == ShapeTool.Rectangle)
            {
                IShape hint = new Rectangle(x, y, x, y);
                _model.CanvasPressed(hint);
            }
            else if (_shapeTool == ShapeTool.Circle)
            {
                IShape hint = new Circle(x, y, x, y);
                _model.CanvasPressed(hint);
            }
        }

        // 在畫布中放開左鍵
        public void CanvasReleased(int x, int y)
        {
            _model.CanvasReleased(x, y);
        }

        // 在畫布中移動
        public void CanvasMoved(int x, int y)
        {
            _model.CanvasMoved(x, y);
        }
        
        // 畫布繪圖
        public void Draw(System.Drawing.Graphics graphics)
        {
            // graphics物件是Paint事件帶進來的，只能在當次Paint使用
            // 而Adaptor又直接使用graphics，這樣DoubleBuffer才能正確運作
            // 因此，Adaptor不能重複使用，每次都要重新new
            _model.Draw(new WindowsFormsGraphicsAdaptor(graphics));
        }
    }
}
