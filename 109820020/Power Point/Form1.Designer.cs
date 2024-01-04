
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
            this._splitContainerData = new System.Windows.Forms.SplitContainer();
            this._shapeDropDownList = new System.Windows.Forms.ComboBox();
            this._addShapeButton = new System.Windows.Forms.Button();
            this._menu = new System.Windows.Forms.MenuStrip();
            this._menuDescription = new System.Windows.Forms.ToolStripMenuItem();
            this._menuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._toolBar = new System.Windows.Forms.ToolStrip();
            this._toolLine = new System.Windows.Forms.ToolStripButton();
            this._toolRectangle = new System.Windows.Forms.ToolStripButton();
            this._toolCircle = new System.Windows.Forms.ToolStripButton();
            this._toolPointer = new System.Windows.Forms.ToolStripButton();
            this._toolAdd = new System.Windows.Forms.ToolStripButton();
            this._toolUndo = new System.Windows.Forms.ToolStripButton();
            this._toolRedo = new System.Windows.Forms.ToolStripButton();
            this._splitContainerAll = new System.Windows.Forms.SplitContainer();
            this._splitContainerRight = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this._shapeDataGridView)).BeginInit();
            this._dataGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerData)).BeginInit();
            this._splitContainerData.Panel1.SuspendLayout();
            this._splitContainerData.Panel2.SuspendLayout();
            this._splitContainerData.SuspendLayout();
            this._menu.SuspendLayout();
            this._toolBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerAll)).BeginInit();
            this._splitContainerAll.Panel2.SuspendLayout();
            this._splitContainerAll.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerRight)).BeginInit();
            this._splitContainerRight.Panel2.SuspendLayout();
            this._splitContainerRight.SuspendLayout();
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
            this._shapeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this._shapeDataGridView.Location = new System.Drawing.Point(16, 16);
            this._shapeDataGridView.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._shapeDataGridView.Name = "_shapeDataGridView";
            this._shapeDataGridView.RowHeadersVisible = false;
            this._shapeDataGridView.RowHeadersWidth = 82;
            this._shapeDataGridView.RowTemplate.Height = 38;
            this._shapeDataGridView.Size = new System.Drawing.Size(174, 636);
            this._shapeDataGridView.TabIndex = 3;
            this._shapeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeleteShapeClick);
            // 
            // _deleteColumn
            // 
            this._deleteColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this._deleteColumn.HeaderText = "刪除";
            this._deleteColumn.MinimumWidth = 10;
            this._deleteColumn.Name = "_deleteColumn";
            this._deleteColumn.ReadOnly = true;
            this._deleteColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._deleteColumn.Text = "刪除";
            this._deleteColumn.UseColumnTextForButtonValue = true;
            this._deleteColumn.Width = 64;
            // 
            // _shapeColumn
            // 
            this._shapeColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this._shapeColumn.DataPropertyName = "Name";
            this._shapeColumn.HeaderText = "形狀";
            this._shapeColumn.MinimumWidth = 10;
            this._shapeColumn.Name = "_shapeColumn";
            this._shapeColumn.ReadOnly = true;
            this._shapeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this._shapeColumn.Width = 103;
            // 
            // _dataColumn
            // 
            this._dataColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this._dataColumn.DataPropertyName = "Info";
            this._dataColumn.HeaderText = "資訊";
            this._dataColumn.MinimumWidth = 10;
            this._dataColumn.Name = "_dataColumn";
            this._dataColumn.ReadOnly = true;
            this._dataColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // _dataGroupBox
            // 
            this._dataGroupBox.Controls.Add(this._splitContainerData);
            this._dataGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this._dataGroupBox.Location = new System.Drawing.Point(13, 13);
            this._dataGroupBox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._dataGroupBox.Name = "_dataGroupBox";
            this._dataGroupBox.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._dataGroupBox.Size = new System.Drawing.Size(210, 754);
            this._dataGroupBox.TabIndex = 4;
            this._dataGroupBox.TabStop = false;
            this._dataGroupBox.Text = "資料顯示";
            // 
            // _splitContainerData
            // 
            this._splitContainerData.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerData.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitContainerData.IsSplitterFixed = true;
            this._splitContainerData.Location = new System.Drawing.Point(2, 32);
            this._splitContainerData.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this._splitContainerData.Name = "_splitContainerData";
            this._splitContainerData.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // _splitContainerData.Panel1
            // 
            this._splitContainerData.Panel1.Controls.Add(this._shapeDropDownList);
            this._splitContainerData.Panel1.Controls.Add(this._addShapeButton);
            this._splitContainerData.Panel1MinSize = 0;
            // 
            // _splitContainerData.Panel2
            // 
            this._splitContainerData.Panel2.Controls.Add(this._shapeDataGridView);
            this._splitContainerData.Panel2.Padding = new System.Windows.Forms.Padding(16, 16, 16, 16);
            this._splitContainerData.Panel2MinSize = 0;
            this._splitContainerData.Size = new System.Drawing.Size(206, 719);
            this._splitContainerData.SplitterDistance = 45;
            this._splitContainerData.SplitterWidth = 6;
            this._splitContainerData.TabIndex = 4;
            // 
            // _shapeDropDownList
            // 
            this._shapeDropDownList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._shapeDropDownList.FormattingEnabled = true;
            this._shapeDropDownList.Items.AddRange(new object[] {
            "線",
            "矩形",
            "圓"});
            this._shapeDropDownList.Location = new System.Drawing.Point(154, 21);
            this._shapeDropDownList.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._shapeDropDownList.Name = "_shapeDropDownList";
            this._shapeDropDownList.Size = new System.Drawing.Size(183, 32);
            this._shapeDropDownList.TabIndex = 1;
            // 
            // _addShapeButton
            // 
            this._addShapeButton.Location = new System.Drawing.Point(21, 21);
            this._addShapeButton.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this._addShapeButton.Name = "_addShapeButton";
            this._addShapeButton.Size = new System.Drawing.Size(94, 51);
            this._addShapeButton.TabIndex = 0;
            this._addShapeButton.Text = "新增";
            this._addShapeButton.UseVisualStyleBackColor = true;
            this._addShapeButton.Click += new System.EventHandler(this.AddButtonClick);
            // 
            // _menu
            // 
            this._menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this._menu.ImageScalingSize = new System.Drawing.Size(32, 32);
            this._menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuDescription});
            this._menu.Location = new System.Drawing.Point(0, 0);
            this._menu.Name = "_menu";
            this._menu.Padding = new System.Windows.Forms.Padding(10, 3, 0, 3);
            this._menu.Size = new System.Drawing.Size(1734, 40);
            this._menu.TabIndex = 5;
            this._menu.Text = "menu";
            // 
            // _menuDescription
            // 
            this._menuDescription.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._menuAbout});
            this._menuDescription.Name = "_menuDescription";
            this._menuDescription.Size = new System.Drawing.Size(81, 34);
            this._menuDescription.Text = "說明";
            // 
            // _menuAbout
            // 
            this._menuAbout.Name = "_menuAbout";
            this._menuAbout.Size = new System.Drawing.Size(193, 44);
            this._menuAbout.Text = "關於";
            // 
            // _toolBar
            // 
            this._toolBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolLine,
            this._toolRectangle,
            this._toolCircle,
            this._toolPointer,
            this._toolAdd,
            this._toolUndo,
            this._toolRedo});
            this._toolBar.Location = new System.Drawing.Point(0, 40);
            this._toolBar.Name = "_toolBar";
            this._toolBar.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this._toolBar.Size = new System.Drawing.Size(1734, 30);
            this._toolBar.TabIndex = 6;
            this._toolBar.Text = "toolStrip1";
            // 
            // _toolLine
            // 
            this._toolLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolLine.Image = global::Power_Point.Properties.Resources.Line;
            this._toolLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolLine.Name = "_toolLine";
            this._toolLine.Size = new System.Drawing.Size(46, 24);
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
            this._toolRectangle.Size = new System.Drawing.Size(46, 24);
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
            this._toolCircle.Size = new System.Drawing.Size(46, 24);
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
            this._toolPointer.Size = new System.Drawing.Size(46, 24);
            this._toolPointer.Text = "toolStripButton1";
            this._toolPointer.ToolTipText = "Pointer";
            this._toolPointer.Click += new System.EventHandler(this.ToolPointerClick);
            // 
            // _toolAdd
            // 
            this._toolAdd.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolAdd.Image = global::Power_Point.Properties.Resources.Add;
            this._toolAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolAdd.Name = "_toolAdd";
            this._toolAdd.Size = new System.Drawing.Size(46, 24);
            this._toolAdd.Text = "toolStripButton1";
            this._toolAdd.ToolTipText = "Add";
            this._toolAdd.Click += new System.EventHandler(this.ToolAddClick);
            // 
            // _toolUndo
            // 
            this._toolUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolUndo.Enabled = false;
            this._toolUndo.Image = global::Power_Point.Properties.Resources.Undo;
            this._toolUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolUndo.Name = "_toolUndo";
            this._toolUndo.Size = new System.Drawing.Size(46, 24);
            this._toolUndo.Text = "Undo";
            this._toolUndo.ToolTipText = "Circle";
            this._toolUndo.Click += new System.EventHandler(this.ToolUndoClick);
            // 
            // _toolRedo
            // 
            this._toolRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._toolRedo.Enabled = false;
            this._toolRedo.Image = global::Power_Point.Properties.Resources.Redo;
            this._toolRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toolRedo.Name = "_toolRedo";
            this._toolRedo.Size = new System.Drawing.Size(46, 24);
            this._toolRedo.Text = "Redo";
            this._toolRedo.ToolTipText = "Circle";
            this._toolRedo.Click += new System.EventHandler(this.ToolRedoClick);
            // 
            // _splitContainerAll
            // 
            this._splitContainerAll.BackColor = System.Drawing.SystemColors.ScrollBar;
            this._splitContainerAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerAll.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this._splitContainerAll.Location = new System.Drawing.Point(0, 70);
            this._splitContainerAll.Name = "_splitContainerAll";
            // 
            // _splitContainerAll.Panel1
            // 
            this._splitContainerAll.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this._splitContainerAll.Panel1.Padding = new System.Windows.Forms.Padding(10, 14, 10, 14);
            // 
            // _splitContainerAll.Panel2
            // 
            this._splitContainerAll.Panel2.Controls.Add(this._splitContainerRight);
            this._splitContainerAll.Size = new System.Drawing.Size(1734, 780);
            this._splitContainerAll.SplitterDistance = 125;
            this._splitContainerAll.SplitterWidth = 6;
            this._splitContainerAll.TabIndex = 7;
            this._splitContainerAll.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainerAllSplitterMoved);
            // 
            // _splitContainerRight
            // 
            this._splitContainerRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this._splitContainerRight.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this._splitContainerRight.Location = new System.Drawing.Point(0, 0);
            this._splitContainerRight.Name = "_splitContainerRight";
            // 
            // _splitContainerRight.Panel1
            // 
            this._splitContainerRight.Panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this._splitContainerRight.Panel1.Padding = new System.Windows.Forms.Padding(10, 13, 10, 13);
            // 
            // _splitContainerRight.Panel2
            // 
            this._splitContainerRight.Panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this._splitContainerRight.Panel2.Controls.Add(this._dataGroupBox);
            this._splitContainerRight.Panel2.Padding = new System.Windows.Forms.Padding(13, 13, 13, 13);
            this._splitContainerRight.Size = new System.Drawing.Size(1603, 780);
            this._splitContainerRight.SplitterDistance = 1361;
            this._splitContainerRight.SplitterWidth = 6;
            this._splitContainerRight.TabIndex = 5;
            this._splitContainerRight.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.SplitContainerRightSplitterMoved);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1734, 850);
            this.Controls.Add(this._splitContainerAll);
            this.Controls.Add(this._toolBar);
            this.Controls.Add(this._menu);
            this.KeyPreview = true;
            this.MainMenuStrip = this._menu;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Form1";
            this.Text = "Power Point";
            ((System.ComponentModel.ISupportInitialize)(this._shapeDataGridView)).EndInit();
            this._dataGroupBox.ResumeLayout(false);
            this._splitContainerData.Panel1.ResumeLayout(false);
            this._splitContainerData.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerData)).EndInit();
            this._splitContainerData.ResumeLayout(false);
            this._menu.ResumeLayout(false);
            this._menu.PerformLayout();
            this._toolBar.ResumeLayout(false);
            this._toolBar.PerformLayout();
            this._splitContainerAll.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerAll)).EndInit();
            this._splitContainerAll.ResumeLayout(false);
            this._splitContainerRight.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._splitContainerRight)).EndInit();
            this._splitContainerRight.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView _shapeDataGridView;
        private System.Windows.Forms.GroupBox _dataGroupBox;
        private System.Windows.Forms.Button _addShapeButton;
        private System.Windows.Forms.MenuStrip _menu;
        private System.Windows.Forms.ToolStripMenuItem _menuDescription;
        private System.Windows.Forms.ToolStripMenuItem _menuAbout;
        private System.Windows.Forms.ToolStrip _toolBar;
        private System.Windows.Forms.ToolStripButton _toolLine;
        private System.Windows.Forms.ToolStripButton _toolRectangle;
        private System.Windows.Forms.ToolStripButton _toolCircle;
        private System.Windows.Forms.ToolStripButton _toolPointer;
        private System.Windows.Forms.SplitContainer _splitContainerAll;
        private System.Windows.Forms.SplitContainer _splitContainerRight;
        private System.Windows.Forms.DataGridViewButtonColumn _deleteColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _shapeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn _dataColumn;
        private System.Windows.Forms.SplitContainer _splitContainerData;
        private System.Windows.Forms.ComboBox _shapeDropDownList;
        private System.Windows.Forms.ToolStripButton _toolUndo;
        private System.Windows.Forms.ToolStripButton _toolRedo;
        private System.Windows.Forms.ToolStripButton _toolAdd;
    }
}

