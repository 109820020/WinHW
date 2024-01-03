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
        private const string LINE = "Line";
        private const string RECTANGLE = "Rectangle";
        private const string CIRCLE = "Circle";
        private const string POINTER = "Pointer";
        private const string KEY_DELETE = "Delete";
        private Model _model;

        public FormPresentationModel(Model model)
        {
            this._model = model;
        }

        // 鍵盤輸入
        public void KeyDown(Keys key)
        {
            if (key == Keys.Delete)
            {
                _model.KeyDown(KEY_DELETE);
            }
        }

        // 工具列按鈕被按下
        public void ToolBarClick(string shapeType)
        {
            _model.ChangeState(shapeType);
        }
        
        // 工具列線是否按下
        public bool IsToolLineChecked()
        {
            return _model.GetToolState() == LINE;
        }
        
        // 工具列矩形是否按下
        public bool IsToolRectangleChecked()
        {
            return _model.GetToolState() == RECTANGLE;
        }
        
        // 工具列圓是否按下
        public bool IsToolCircleChecked()
        {
            return _model.GetToolState() == CIRCLE;
        }

        // 工具列指標是否按下
        public bool IsToolPointerChecked()
        {
            return _model.GetToolState() == POINTER;
        }

        // 取得游標類型
        public Cursor GetCanvasCursorType()
        {
            return _model.GetToolState() == POINTER ? Cursors.Default : Cursors.Cross;
        }

        //  在畫布中按下左鍵
        public void CanvasPressed(int pointX, int pointY)
        {
            _model.CanvasPressed(pointX, pointY);
        }

        // 在畫布中放開左鍵
        public void CanvasReleased(int pointX, int pointY)
        {
            _model.CanvasReleased(pointX, pointY);
        }

        // 在畫布中移動
        public void CanvasMoved(int pointX, int pointY)
        {
            _model.CanvasMoved(pointX, pointY);
        }
        
        // 畫布繪圖
        public void Draw(System.Drawing.Graphics graphics)
        {
            // graphics物件是Paint事件帶進來的，只能在當次Paint使用
            // 而Adaptor又直接使用graphics，這樣DoubleBuffer才能正確運作
            // 因此，Adaptor不能重複使用，每次都要重新new
            _model.Draw(new FormGraphicsAdapter(graphics));
        }
    }
}
