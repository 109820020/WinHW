using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Point
{
    public partial class Form1 : Form
    {
        private const int CANVAS_RELATIVE_WIDTH = 1600;
        private const int CANVAS_RELATIVE_HIGHT = 900;
        
        private Model _model;
        private FormPresentationModel _formPresentationModel;
        private Panel _canvas;
        private List<Button> _pages;

        public Form1(Model model, FormPresentationModel formPresentationModel)
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormKeyDown);

            // prepare presentation model and model
            this._model = model;
            _model._modelChanged += HandleModelChanged;
            this._formPresentationModel = formPresentationModel;

            // button
            _pages = new List<Button>();
            _formPresentationModel.RefreshPagesSize(_pages, _splitContainerAll);

            // prepare canvas
            _canvas = new DoubleBufferedPanel();
            _canvas = new DoubleBufferedPanel();
            _formPresentationModel.SetCanvasLocationAndSize(_canvas, _splitContainerRight.Panel1.Width,
                _splitContainerRight.Panel1.Height);
            _formPresentationModel.SetCanvasActualSize(_canvas.Width, _canvas.Height);
            _canvas.BackColor = System.Drawing.Color.White;
            _canvas.MouseDown += HandleCanvasPressed;
            _canvas.MouseUp += HandleCanvasReleased;
            _canvas.MouseMove += HandleCanvasMoved;
            _canvas.Paint += HandleCanvasPaint;
            _splitContainerRight.Panel1.Controls.Add(_canvas);

            // _shapeDataGridView binding
            _shapeDataGridView.AutoGenerateColumns = false;
            _shapeDataGridView.DataSource = _model.Shapes;

            // 設定畫布相對大小
            _formPresentationModel.SetCanvasRelativeSize(CANVAS_RELATIVE_WIDTH, CANVAS_RELATIVE_HIGHT);

            this.Resize += new System.EventHandler(this.ResizeHandler);
            _shapeDropDownList.SelectedItem = "線";
            RefreshControls();
        }

        // 更新畫面
        private void RefreshControls()
        {
            _toolLine.Checked = _formPresentationModel.IsToolLineChecked();
            _toolRectangle.Checked = _formPresentationModel.IsToolRectangleChecked();
            _toolCircle.Checked = _formPresentationModel.IsToolCircleChecked();
            _toolPointer.Checked = _formPresentationModel.IsToolPointerChecked();
            _toolUndo.Enabled = _model.IsUndoEnabled();
            _toolRedo.Enabled = _model.IsRedoEnabled();
            _canvas.Cursor = _formPresentationModel.GetCanvasCursorType();
            _formPresentationModel.RefreshButtonImage(_pages);
        }

        // 鍵盤輸入
        public void FormKeyDown(object sender, KeyEventArgs e)
        {
            _formPresentationModel.KeyDown(e.KeyCode);
            _formPresentationModel.RefreshPagesSize(_pages, _splitContainerAll);
            RefreshControls();
        }

        // Button1Click
        private void Button1Click(object sender, EventArgs e)
        {
        }

        // 新增Shape
        private void AddButtonClick(object sender, EventArgs e)
        {
            string shape = _shapeDropDownList.SelectedItem.ToString();
            _model.AddShapeToCommandManager(shape);
        }

        // 刪除形狀按鈕
        private void DeleteShapeClick(object sender, DataGridViewCellEventArgs e)
        {
            _model.DeleteShapeToCommandManager(e.RowIndex);
        }

        // 工具列線按下
        private void ToolLineClick(object sender, EventArgs e)
        {
            _model.ChangeState("Line");
            RefreshControls();
        }

        // 工具列矩形按下
        private void ToolRectangleClick(object sender, EventArgs e)
        {
            _model.ChangeState("Rectangle");
            RefreshControls();
        }

        // 工具列圓按下
        private void ToolCircleClick(object sender, EventArgs e)
        {
            _model.ChangeState("Circle");
            RefreshControls();
        }

        // 工具列Pointer按下
        private void ToolPointerClick(object sender, EventArgs e)
        {
            _model.ChangeState("Pointer");
            RefreshControls();
        }

        // 工具列新增頁面按下
        private void ToolAddClick(object sender, EventArgs e)
        {
            _model.AddPage();
            _formPresentationModel.RefreshPagesSize(_pages, _splitContainerAll);
            RefreshControls();
        }

        // 工具列Undo
        private void ToolUndoClick(object sender, EventArgs e)
        {
            _model.Undo();
            _formPresentationModel.RefreshPagesSize(_pages, _splitContainerAll);
            RefreshControls();
        }

        // 工具列Redo
        private void ToolRedoClick(object sender, EventArgs e)
        {
            _model.Redo();
            _formPresentationModel.RefreshPagesSize(_pages, _splitContainerAll);
            RefreshControls();
        }

        // 在畫布中按下左鍵
        public void HandleCanvasPressed(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _formPresentationModel.CanvasPressed(e.X, e.Y);
        }

        // 在畫布中放開左鍵
        public void HandleCanvasReleased(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _formPresentationModel.CanvasReleased(e.X, e.Y);
        }

        // 在畫布中移動
        public void HandleCanvasMoved(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            _formPresentationModel.CanvasMoved(e.X, e.Y);
        }

        // 畫布繪圖
        public void HandleCanvasPaint(object sender, System.Windows.Forms.PaintEventArgs e)
        {
            
            _formPresentationModel.Draw(e.Graphics);
        }

        // model改變時會以事件通知此func
        public void HandleModelChanged()
        {
            RefreshControls();
            Invalidate(true);
        }

        // SplitContainerAll Splitter 移動時
        public void SplitContainerAllSplitterMoved(Object sender, System.Windows.Forms.SplitterEventArgs e)
        {
            if (_canvas != null)
            {
                _formPresentationModel.SetCanvasLocationAndSize(_canvas, _splitContainerRight.Panel1.Width,
                _splitContainerRight.Panel1.Height);
                _formPresentationModel.SetCanvasActualSize(_canvas.Width, _canvas.Height);
            }
            _formPresentationModel.RefreshPagesSize(_pages, _splitContainerAll);
            Invalidate(true);
        }

        // SplitContainerRight Splitter 移動時
        public void SplitContainerRightSplitterMoved(Object sender, System.Windows.Forms.SplitterEventArgs e)
        {
            if (_canvas != null)
            {
                _formPresentationModel.SetCanvasLocationAndSize(_canvas, _splitContainerRight.Panel1.Width,
                _splitContainerRight.Panel1.Height);
                _formPresentationModel.SetCanvasActualSize(_canvas.Width, _canvas.Height);
            }
            Invalidate(true);
        }

        // Resize
        public void ResizeHandler(Object sender, EventArgs e)
        {
            if (_canvas != null)
            {
                _formPresentationModel.SetCanvasLocationAndSize(_canvas, _splitContainerRight.Panel1.Width,
                _splitContainerRight.Panel1.Height);
                _formPresentationModel.SetCanvasActualSize(_canvas.Width, _canvas.Height);
            }
            Invalidate(true);
        }
    }
}