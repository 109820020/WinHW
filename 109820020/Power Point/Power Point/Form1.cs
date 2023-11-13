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
        Panel _canvas; // private

        public Form1(Model model, FormPresentationModel formPresentationModel)
        {
            InitializeComponent();
            
            // prepare presentation model and model
            this._model = model;
            _model._modelChanged += HandleModelChanged;
            this._formPresentationModel = formPresentationModel;

            // prepare canvas
            _canvas = new DoubleBufferedPanel();
            _canvas.Location = new System.Drawing.Point(115, 54);
            _canvas.Size = new System.Drawing.Size(882, 668);
            _canvas.BackColor = System.Drawing.Color.White;
            _canvas.MouseDown += HandleCanvasPressed;
            _canvas.MouseUp += HandleCanvasReleased;
            _canvas.MouseMove += HandleCanvasMoved;
            _canvas.Paint += HandleCanvasPaint;
            Controls.Add(_canvas);

            _shapeDropDownList.SelectedItem = "線";
            RefreshControls();
        }
        
        // 更新畫面
        private void RefreshControls()
        {
            _toolLine.Checked = _formPresentationModel.IsToolLineChecked();
            _toolRectangle.Checked = _formPresentationModel.IsToolRectangleChecked();
            _toolCircle.Checked = _formPresentationModel.IsToolCircleChecked();
            Cursor = _formPresentationModel.GetCursorType();
            
            // dataGridView rows refresh
            List<string> shapeName = _model.GetAllshapeName();
            List<string> shapeInfo = _model.GetAllShapeInfo();
            _shapeDataGridView.Rows.Clear();
            for (int i = 0; i < shapeName.Count; i++)
                _shapeDataGridView.Rows.Add("", shapeName[i], shapeInfo[i]);
        }
        
        // Button1Click
        private void Button1Click(object sender, EventArgs e)
        {
        }
        
        // Button2Click
        private void Button2Click(object sender, EventArgs e)
        {
        }
        
        // 新增Shape
        private void NewButtonClick(object sender, EventArgs e)
        {
            string shape = _shapeDropDownList.SelectedItem.ToString();
            _model.AddShape(shape);
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
            _formPresentationModel.ToolBarClick("Rect");
            RefreshControls();
        }
        
        // 工具列圓按下
        private void ToolCircleClick(object sender, EventArgs e)
        {
            _formPresentationModel.ToolBarClick("Circle");
            RefreshControls();
        }

        //
        private void ToolPointerClick(object sender, EventArgs e)
        {

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
    }
}
