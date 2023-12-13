using Microsoft.VisualStudio.TestTools.UnitTesting;
using Power_Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Power_Point.Tests
{
    [TestClass()]
    public class FormGraphicsAdapterTests
    {
        Graphics _graphics;
        FormGraphicsAdapter _formGraphicsAdapter;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            Model model = new Model();
            Form1 form = new Form1(model, new FormPresentationModel(model));
            _graphics = form.CreateGraphics();

            _formGraphicsAdapter = new FormGraphicsAdapter(_graphics);
        }

        // ClearAllTest
        [TestMethod()]
        public void ClearAllTest()
        {
            _formGraphicsAdapter.ClearAll();
        }

        // DrawLineTest
        [TestMethod()]
        public void DrawLineTest()
        {
            _formGraphicsAdapter.DrawLine(0, 1, 2, 3);
            _formGraphicsAdapter.DrawLine(0, 1, 2, 3, "Gray");
            _formGraphicsAdapter.DrawLine(0, 0, 0, 0, "Black");
        }

        // DrawRectangleTest
        [TestMethod()]
        public void DrawRectangleTest()
        {
            _formGraphicsAdapter.DrawRectangle(0, 1, 2, 3);
            _formGraphicsAdapter.DrawRectangle(0, 1, 2, 3, "Gray");
            _formGraphicsAdapter.DrawRectangle(0, 0, 0, 0, "Black");
        }

        // DrawCircleTest
        [TestMethod()]
        public void DrawCircleTest()
        {
            _formGraphicsAdapter.DrawCircle(0, 1, 2, 3);
            _formGraphicsAdapter.DrawCircle(0, 1, 2, 3, "Gray");
            _formGraphicsAdapter.DrawCircle(0, 0, 0, 0, "Black");
        }
    }
}