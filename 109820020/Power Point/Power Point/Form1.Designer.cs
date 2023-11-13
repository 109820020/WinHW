
namespace Power_Point
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._shapeDataGridView = new System.Windows.Forms.DataGridView();
            this._deleteColumn = new System.Windows.Forms.DataGridViewButtonColumn();
            this._shapeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this._dataGroupBox = new System.Windows.Forms.GroupBox();
            this._shapeDropDownList = new System.Windows.Forms.ComboBox();
            this._newShapeButton = new System.Windows.Forms.Button();
            this._menu = new System.Windows.Forms.MenuStrip();
            this._menuDescription = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._button1 = new System.Windows.Forms.Button();
            this._button2 = new System.Windows.Forms.Button();
            this._toolBar = new System.Windows.Forms.ToolStrip();
            this._toolLine = new System.Windows.Forms.ToolStripButton();
            this._toolRectangle = new System.Windows.Forms.ToolStripButton();
            this._toolCircle = new System.Windows.Forms.ToolStripButton();
            this._toolPointer = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this._shapeDataGridView)).BeginInit();
            this._dataGroupBox.SuspendLayout();
            this._menu.SuspendLayout();
            this._toolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // _shapeDataGridView
            // 
            this._shapeDataGridView.AllowUserToAddRows = false;
            this._shapeDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this._shapeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._shapeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this._deleteColumn,
            this._shapeColumn,
            this._dataColumn});
            this._shapeDataGridView.Location = new System.Drawing.Point(9, 56);
            this._shapeDataGridView.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._shapeDataGridView.Name = "_shapeDataGridView";
            this._shapeDataGridView.RowHeadersVisible = false;
            this._shapeDataGridView.RowHeadersWidth = 82;
            this._shapeDataGridView.RowTemplate.Height = 38;
            this._shapeDataGridView.Size = new System.Drawing.Size(348, 778);
            this._shapeDataGridView.TabIndex = 3;
            this._shapeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteShapeClick);
            // 
            // _deleteColumn
            // 
            this._deleteColumn.HeaderText = "刪除";
            this._deleteColumn.MinimumWidth = 10;
            this._deleteColumn.Name = "_deleteColumn";
            this._deleteColumn.ReadOnly = true;
            this._deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._deleteColumn.Text = "刪除";
            this._deleteColumn.UseColumnTextForButtonValue = true;
            this._deleteColumn.Width = 43;
            // 
            // _shapeColumn
            // 
            this._shapeColumn.HeaderText = "形狀";
            this._shapeColumn.MinimumWidth = 10;
            this._shapeColumn.Name = "_shapeColumn";
            this._shapeColumn.ReadOnly = true;
            this._shapeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._shapeColumn.Width = 66;
            // 
            // _dataColumn
            // 
            this._dataColumn.HeaderText = "資訊";
            this._dataColumn.MinimumWidth = 10;
            this._dataColumn.Name = "_dataColumn";
            this._dataColumn.ReadOnly = true;
            this._dataColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._dataColumn.Width = 66;
            // 
            // _dataGroupBox
            // 
            this._dataGroupBox.Controls.Add(this._shapeDropDownList);
            this._dataGroupBox.Controls.Add(this._shapeDataGridView);
            this._dataGroupBox.Controls.Add(this._newShapeButton);
            this._dataGroupBox.Location = new System.Drawing.Point(1338, 63);
            this._dataGroupBox.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._dataGroupBox.Name = "_dataGroupBox";
            this._dataGroupBox.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._dataGroupBox.Size = new System.Drawing.Size(366, 843);
            this._dataGroupBox.TabIndex = 4;
            this._dataGroupBox.TabStop = false;
            this._dataGroupBox.Text = "資料顯示";
            // 
            // _shapeDropDownList
            // 
            this._shapeDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._shapeDropDownList.FormattingEnabled = true;
            this._shapeDropDownList.Items.AddRange(new object[] {
            "線",
            "矩形",
            "圓"});
            this._shapeDropDownList.Location = new System.Drawing.Point(78, 22);
            this._shapeDropDownList.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._shapeDropDownList.Name = "_shapeDropDownList";
            this._shapeDropDownList.Size = new System.Drawing.Size(114, 23);
            this._shapeDropDownList.TabIndex = 1;
            // 
            // _newShapeButton
            // 
            this._newShapeButton.Location = new System.Drawing.Point(9, 21);
            this._newShapeButton.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._newShapeButton.Name = "_newShapeButton";
            this._newShapeButton.Size = new System.Drawing.Size(58, 32);
            this._newShapeButton.TabIndex = 0;
            this._newShapeButton.Text = "新增";
            this._newShapeButton.UseVisualStyleBackColor = true;
            this._newShapeButton.Click += new System.EventHandler(this.NewButtonClick);
            // 
            // _menu
            // 
            this._menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuDescription});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Size = new System.Drawing.Size(1184, 27);
            this._menu.TabIndex = 5;
            this._menu.Text = "menu";
            // 
            // _menuDescription
            // 
            this._menuDescription.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuAbout});
            this._menuDescription.Name = "_menuDescription";
            this._menuDescription.Size = new System.Drawing.Size(53, 23);
            this._menuDescription.Text = "說明";
            // 
            // _menuAbout
            // 
            this._menuAbout.Name = "_menuAbout";
            this._menuAbout.Size = new System.Drawing.Size(122, 26);
            this._menuAbout.Text = "關於";
            // 
            // _button1
            // 
            this._button1.Location = new System.Drawing.Point(9, 63);
            this._button1.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._button1.Name = "_button1";
            this._button1.Size = new System.Drawing.Size(138, 83);
            this._button1.TabIndex = 1;
            this._button1.UseVisualStyleBackColor = true;
            this._button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // _button2
            // 
            this._button2.Location = new System.Drawing.Point(9, 158);
            this._button2.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this._button2.Name = "_button2";
            this._button2.Size = new System.Drawing.Size(138, 83);
            this._button2.TabIndex = 2;
            this._button2.UseVisualStyleBackColor = true;
            this._button2.Click += new System.EventHandler(this.Button2Click);
            // 
            // _toolBar
            // 
            this._toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolLine,
            this._toolRectangle,
            this._toolCircle,
            this._toolPointer});
            this._toolBar.Location = new System.Drawing.Point(0, 27);
            this._toolBar.Name = "_toolBar";
            this._toolBar.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this._toolBar.Size = new System.Drawing.Size(1184, 27);
            this._toolBar.TabIndex = 6;
            this._toolBar.Text = "toolStrip1";
            // 
            // _toolLine
            // 
            this._toolLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolLine.Image = global::Power_Point.Properties.Resources.Line;
            this._toolLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolLine.Name = "_toolLine";
            this._toolLine.Size = new System.Drawing.Size(29, 24);
            this._toolLine.Text = "Line";
            this._toolLine.ToolTipText = "Line";
            this._toolLine.Click += new System.EventHandler(this.ToolLineClick);
            // 
            // _toolRectangle
            // 
            this._toolRectangle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolRectangle.Image = global::Power_Point.Properties.Resources.Rect;
            this._toolRectangle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolRectangle.Name = "_toolRectangle";
            this._toolRectangle.Size = new System.Drawing.Size(29, 24);
            this._toolRectangle.Text = "Rectangle";
            this._toolRectangle.ToolTipText = "Rectangle";
            this._toolRectangle.Click += new System.EventHandler(this.ToolRectangleClick);
            // 
            // _toolCircle
            // 
            this._toolCircle.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolCircle.Image = global::Power_Point.Properties.Resources.Circle;
            this._toolCircle.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolCircle.Name = "_toolCircle";
            this._toolCircle.Size = new System.Drawing.Size(29, 24);
            this._toolCircle.Text = "Circle";
            this._toolCircle.ToolTipText = "Circle";
            this._toolCircle.Click += new System.EventHandler(this.ToolCircleClick);
            // 
            // _toolPointer
            // 
            this._toolPointer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolPointer.Image = global::Power_Point.Properties.Resources.Pointer;
            this._toolPointer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolPointer.Name = "_toolPointer";
            this._toolPointer.Size = new System.Drawing.Size(29, 24);
            this._toolPointer.Text = "toolStripButton1";
            this._toolPointer.ToolTipText = "Pointer";
            this._toolPointer.Click += new System.EventHandler(this.ToolPointerClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1184, 659);
            this.Controls.Add(this._toolBar);
            this.Controls.Add(this._dataGroupBox);
            this.Controls.Add(this._button1);
            this.Controls.Add(this._button2);
            this.Controls.Add(this._menu);
            this.MainMenuStrip = this._menu;
            this.Margin = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.Name = "Form1";
            this.Text = "Power Point";
            ((System.ComponentModel.ISupportInitialize)(this._shapeDataGridView)).EndInit();
            this._dataGroupBox.ResumeLayout(false);
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView _shapeDataGridView;
        private System.Windows.Forms.GroupBox _dataGroupBox;
        private System.Windows.Forms.ComboBox _shapeDropDownList;
        private System.Windows.Forms.Button _newShapeButton;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem _menuDescription;
        private System.Windows.Forms.ToolStripMenuItem _menuAbout;
        private System.Windows.Forms.Button _button1;
        private System.Windows.Forms.Button _button2;
        private System.Windows.Forms.ToolStrip _toolBar;
        private System.Windows.Forms.ToolStripButton _toolLine;
        private System.Windows.Forms.ToolStripButton _toolRectangle;
        private System.Windows.Forms.ToolStripButton _toolCircle;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _shapeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataColumn;
        private System.Windows.Forms.ToolStripButton _toolPointer;
    }
}

