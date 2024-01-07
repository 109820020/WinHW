
namespace Power_Point
{
    partial class NewShapeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._textBoxTopLeftX = new System.Windows.Forms.TextBox();
            this._labelTopLeftX = new System.Windows.Forms.Label();
            this._labelTopLeftY = new System.Windows.Forms.Label();
            this._textBoxTopLeftY = new System.Windows.Forms.TextBox();
            this._labelBottomRightX = new System.Windows.Forms.Label();
            this._textBoxBottomRightX = new System.Windows.Forms.TextBox();
            this._labelBottomRightY = new System.Windows.Forms.Label();
            this._textBoxBottomRightY = new System.Windows.Forms.TextBox();
            this._buttonOk = new System.Windows.Forms.Button();
            this._buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _textBoxTopLeftX
            // 
            this._textBoxTopLeftX.Location = new System.Drawing.Point(28, 48);
            this._textBoxTopLeftX.Name = "_textBoxTopLeftX";
            this._textBoxTopLeftX.Size = new System.Drawing.Size(102, 25);
            this._textBoxTopLeftX.TabIndex = 0;
            this._textBoxTopLeftX.TextChanged += new System.EventHandler(this.TextBoxTopLeftXTextChanged);
            // 
            // _labelTopLeftX
            // 
            this._labelTopLeftX.AutoSize = true;
            this._labelTopLeftX.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelTopLeftX.Location = new System.Drawing.Point(24, 23);
            this._labelTopLeftX.Name = "_labelTopLeftX";
            this._labelTopLeftX.Size = new System.Drawing.Size(106, 22);
            this._labelTopLeftX.TabIndex = 1;
            this._labelTopLeftX.Text = "左上角座標X";
            // 
            // _labelTopLeftY
            // 
            this._labelTopLeftY.AutoSize = true;
            this._labelTopLeftY.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelTopLeftY.Location = new System.Drawing.Point(172, 23);
            this._labelTopLeftY.Name = "_labelTopLeftY";
            this._labelTopLeftY.Size = new System.Drawing.Size(106, 22);
            this._labelTopLeftY.TabIndex = 3;
            this._labelTopLeftY.Text = "左上角座標Y";
            // 
            // _textBoxTopLeftY
            // 
            this._textBoxTopLeftY.Location = new System.Drawing.Point(176, 48);
            this._textBoxTopLeftY.Name = "_textBoxTopLeftY";
            this._textBoxTopLeftY.Size = new System.Drawing.Size(102, 25);
            this._textBoxTopLeftY.TabIndex = 2;
            this._textBoxTopLeftY.TextChanged += new System.EventHandler(this.TextBoxTopLeftYTextChanged);
            // 
            // _labelBottomRightX
            // 
            this._labelBottomRightX.AutoSize = true;
            this._labelBottomRightX.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelBottomRightX.Location = new System.Drawing.Point(24, 103);
            this._labelBottomRightX.Name = "_labelBottomRightX";
            this._labelBottomRightX.Size = new System.Drawing.Size(106, 22);
            this._labelBottomRightX.TabIndex = 5;
            this._labelBottomRightX.Text = "右下角座標X";
            // 
            // _textBoxBottomRightX
            // 
            this._textBoxBottomRightX.Location = new System.Drawing.Point(28, 128);
            this._textBoxBottomRightX.Name = "_textBoxBottomRightX";
            this._textBoxBottomRightX.Size = new System.Drawing.Size(102, 25);
            this._textBoxBottomRightX.TabIndex = 4;
            this._textBoxBottomRightX.TextChanged += new System.EventHandler(this.TextBoxBottomRightXTextChanged);
            // 
            // _labelBottomRightY
            // 
            this._labelBottomRightY.AutoSize = true;
            this._labelBottomRightY.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this._labelBottomRightY.Location = new System.Drawing.Point(172, 103);
            this._labelBottomRightY.Name = "_labelBottomRightY";
            this._labelBottomRightY.Size = new System.Drawing.Size(106, 22);
            this._labelBottomRightY.TabIndex = 7;
            this._labelBottomRightY.Text = "右下角座標Y";
            // 
            // _textBoxBottomRightY
            // 
            this._textBoxBottomRightY.Location = new System.Drawing.Point(176, 128);
            this._textBoxBottomRightY.Name = "_textBoxBottomRightY";
            this._textBoxBottomRightY.Size = new System.Drawing.Size(102, 25);
            this._textBoxBottomRightY.TabIndex = 6;
            this._textBoxBottomRightY.TextChanged += new System.EventHandler(this.TextBoxBottomRightYTextChanged);
            // 
            // _buttonOk
            // 
            this._buttonOk.Location = new System.Drawing.Point(28, 184);
            this._buttonOk.Name = "_buttonOk";
            this._buttonOk.Size = new System.Drawing.Size(102, 23);
            this._buttonOk.TabIndex = 8;
            this._buttonOk.Text = "OK";
            this._buttonOk.UseVisualStyleBackColor = true;
            this._buttonOk.Click += new System.EventHandler(this.ButtonOkClick);
            // 
            // _buttonCancel
            // 
            this._buttonCancel.Location = new System.Drawing.Point(176, 184);
            this._buttonCancel.Name = "_buttonCancel";
            this._buttonCancel.Size = new System.Drawing.Size(102, 23);
            this._buttonCancel.TabIndex = 9;
            this._buttonCancel.Text = "Cancel";
            this._buttonCancel.UseVisualStyleBackColor = true;
            this._buttonCancel.Click += new System.EventHandler(this.ButtonCancelClick);
            // 
            // NewShapeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 233);
            this.Controls.Add(this._buttonCancel);
            this.Controls.Add(this._buttonOk);
            this.Controls.Add(this._labelBottomRightY);
            this.Controls.Add(this._textBoxBottomRightY);
            this.Controls.Add(this._labelBottomRightX);
            this.Controls.Add(this._textBoxBottomRightX);
            this.Controls.Add(this._labelTopLeftY);
            this.Controls.Add(this._textBoxTopLeftY);
            this.Controls.Add(this._labelTopLeftX);
            this.Controls.Add(this._textBoxTopLeftX);
            this.Name = "NewShapeForm";
            this.Text = "New Shape";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _textBoxTopLeftX;
        private System.Windows.Forms.Label _labelTopLeftX;
        private System.Windows.Forms.Label _labelTopLeftY;
        private System.Windows.Forms.TextBox _textBoxTopLeftY;
        private System.Windows.Forms.Label _labelBottomRightX;
        private System.Windows.Forms.TextBox _textBoxBottomRightX;
        private System.Windows.Forms.Label _labelBottomRightY;
        private System.Windows.Forms.TextBox _textBoxBottomRightY;
        private System.Windows.Forms.Button _buttonOk;
        private System.Windows.Forms.Button _buttonCancel;
    }
}