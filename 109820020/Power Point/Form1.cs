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
        private Model _model;
        private FormPresentationModel _formPresentationModel;
        private Panel _canvas;
        private System.Windows.Forms.Button _button1;

        public Form1(Model model, FormPresentationModel formPresentationModel)
        {
            InitializeComponent();
            this.KeyDown += new KeyEventHandler(FormKeyDown);

            // prepare presentation model and model
            this._model = model;
            _model._modelChanged += HandleModelChanged;
            this._formPresentationModel = formPresentationModel;

            // _button1
            this._button1 = new System.Windows.Forms.Button();
            this._button1.Location = new System.Drawing.Point(5, 5);
            this._button1.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(115, 65);
            this._button1.UseVisualStyleBackColor = true;
            this._button1.Click += new System.EventHandler(this.Button1Click);
            this._splitContainerAll.Panel1.Controls.Add(this._button1);

            // prepare canvas
            _canvas = new DoubleBufferedPanel();
            CanvasSetLocationAndSize();
            _canvas.BackColor = System.Drawing.Color.White;
            _canvas.MouseDown += HandleCanvasPressed;
            _canvas.MouseUp += HandleCanvasReleased;
            _canvas.MouseMove += HandleCanvasMoved;
            _canvas.Paint += HandleCanvasPaint;
            _splitContainerRight.Panel1.Controls.Add(_canvas);

            // _shapeDataGridView binding
            _shapeDataGridView.AutoGenerateColumns = false;
            _shapeDataGridView.DataSource = _model.Shapes;

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
        }

        // canvas 座標Y值
        private void CanvasSetLocationAndSize()
        {
            int canvasWidth = _splitContainerRight.Panel1.Width - 20;
            int canvasHeight = canvasWidth * 9 / 16;
            int canvasLocationY = (_splitContainerRight.Panel1.Height - canvasHeight) / 2;
            canvasLocationY = canvasLocationY >= 0 ? canvasLocationY : 0;

            _canvas.Location = new System.Drawing.Point(10, canvasLocationY);
            _canvas.Size = new System.Drawing.Size(canvasWidth, canvasHeight);
        }

        // 鍵盤輸入
        public void FormKeyDown(object sender, KeyEventArgs e)
        {
            _formPresentationModel.KeyDown(e.KeyCode);
        }

        // Button1Click
        private void Button1Click(object sender, EventArgs e)
        {
        }

        // 新增Shape
        private void AddButtonClick(object sender, EventArgs e)
        {
            string shape = _shapeDropDownList.SelectedItem.ToString();
            _model.AddShapeToCmdManager(shape);
        }

        // 刪除形狀按鈕
        private void DeleteShapeClick(object sender, DataGridViewCellEventArgs e)
        {
            _model.DeleteShape(e.RowIndex);
        }

        // 工具列線按下
        private void ToolLineClick(object sender, EventArgs e)
        {
            _formPresentationModel.ToolBarClick("Line");
            RefreshControls();
        }

        // 工具列矩形按下
        private void ToolRectangleClick(object sender, EventArgs e)
        {
            _formPresentationModel.ToolBarClick("Rectangle");
            RefreshControls();
        }

        // 工具列圓按下
        private void ToolCircleClick(object sender, EventArgs e)
        {
            _formPresentationModel.ToolBarClick("Circle");
            RefreshControls();
        }

        // 工具列Pointer按下
        private void ToolPointerClick(object sender, EventArgs e)
        {
            _formPresentationModel.ToolBarClick("Pointer");
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
            CanvasSetLocationAndSize();
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
            if (_button1 != null)
            { 
                _button1.Width = _splitContainerAll.Panel1.Width - 10;
                _button1.Height = _button1.Width * 9 / 16;
            }
        }

        // SplitContainerRight Splitter 移動時
        public void SplitContainerRightSplitterMoved(Object sender, System.Windows.Forms.SplitterEventArgs e)
        {
            if (_button1 != null)
            {
                _button1.Width = _splitContainerAll.Panel1.Width - 10;
                _button1.Height = _button1.Width * 9 / 16;
            }
        }

        // Undo
        private void ToolUndoClick(object sender, EventArgs e)
        {
            _model.Undo();
            RefreshControls();
        }

        // Redo
        private void ToolRedoClick(object sender, EventArgs e)
        {
            _model.Redo();
            RefreshControls();
        }
    }
}