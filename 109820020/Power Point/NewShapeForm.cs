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
    public partial class NewShapeForm : Form
    {
        private int _topLeftX = -1;
        private int _topLeftY = -1;
        private int _bottomRightX = -1;
        private int _bottomRightY = -1;

        public NewShapeForm()
        {
            InitializeComponent();
            _buttonOk.Enabled = false;
            _buttonCancel.Enabled = true;
        }

        // TopLeftX
        public int TopLeftX
        {
            get
            {
                return _topLeftX;
            }
        }

        // TopLeftY
        public int TopLeftY
        {
            get
            {
                return _topLeftY;
            }
        }

        // BottomRightX
        public int BottomRightX
        {
            get
            {
                return _bottomRightX;
            }
        }

        // BottomRightY
        public int BottomRightY
        {
            get
            {
                return _bottomRightY;
            }
        }

        // text change
        private void TextBoxTopLeftXTextChanged(object sender, EventArgs e)
        {
            TextBoxTextChanged();
        }

        // text change
        private void TextBoxTopLeftYTextChanged(object sender, EventArgs e)
        {
            TextBoxTextChanged();
        }

        // text change
        private void TextBoxBottomRightXTextChanged(object sender, EventArgs e)
        {
            TextBoxTextChanged();
        }

        // text change
        private void TextBoxBottomRightYTextChanged(object sender, EventArgs e)
        {
            TextBoxTextChanged();
        }

        // text change
        private void TextBoxTextChanged()
        {
            try
            {
                _topLeftX = int.Parse(_textBoxTopLeftX.Text);
                _topLeftY = int.Parse(_textBoxTopLeftY.Text);
                _bottomRightX = int.Parse(_textBoxBottomRightX.Text);
                _bottomRightY = int.Parse(_textBoxBottomRightY.Text);
                if (_topLeftX >= 0 && _topLeftX <= 1600 && _topLeftY >= 0 && _topLeftY <= 900 &&
                    _bottomRightX > _topLeftX && _bottomRightX <= 1600 && 
                    _bottomRightY > _topLeftY && _bottomRightY <= 900)
                {
                    _buttonOk.Enabled = true;
                }
                else
                {
                    _buttonOk.Enabled = false;
                }
            }
            catch(Exception e)
            {
                _buttonOk.Enabled = false;
            }
        }

        // ButtonOkClick
        private void ButtonOkClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        // ButtonCancelClick
        private void ButtonCancelClick(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
