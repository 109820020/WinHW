using Microsoft.VisualStudio.TestTools.UnitTesting;
using Power_Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Point.Tests
{
    [TestClass()]
    public class FormPresentationModelTests
    {
        Model _model;
        FormPresentationModel _formPresentationModel;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _model.AddShape(new Line(0, 0, 500, 500));
            _model.AddShape(new Circle(250, 250, 750, 750));

            _formPresentationModel = new FormPresentationModel(_model);
        }

        // KeyDownTest
        [TestMethod()]
        public void KeyDownTest()
        {
            _formPresentationModel.KeyDown(Keys.Delete);
        }

        // ToolBarClickTest
        [TestMethod()]
        public void ToolBarClickTest()
        {
            _formPresentationModel.ToolBarClick("Line");
            Assert.AreEqual("Line", _model.GetToolState());

            _formPresentationModel.ToolBarClick("Pointer");
            Assert.AreEqual("Pointer", _model.GetToolState());
        }

        // IsToolLineCheckedTest
        [TestMethod()]
        public void IsToolLineCheckedTest()
        {
            Assert.IsFalse(_formPresentationModel.IsToolLineChecked());
            _formPresentationModel.ToolBarClick("Line");
            Assert.IsTrue(_formPresentationModel.IsToolLineChecked());
        }

        // IsToolRectangleCheckedTest
        [TestMethod()]
        public void IsToolRectangleCheckedTest()
        {
            Assert.IsFalse(_formPresentationModel.IsToolRectangleChecked());
            _formPresentationModel.ToolBarClick("Rectangle");
            Assert.IsTrue(_formPresentationModel.IsToolRectangleChecked());
        }

        // IsToolCircleCheckedTest
        [TestMethod()]
        public void IsToolCircleCheckedTest()
        {
            Assert.IsFalse(_formPresentationModel.IsToolCircleChecked());
            _formPresentationModel.ToolBarClick("Circle");
            Assert.IsTrue(_formPresentationModel.IsToolCircleChecked());
        }

        // IsToolPointerCheckedTest
        [TestMethod()]
        public void IsToolPointerCheckedTest()
        {
            _formPresentationModel.ToolBarClick("Circle");
            Assert.IsFalse(_formPresentationModel.IsToolPointerChecked());
            _formPresentationModel.ToolBarClick("Pointer");
            Assert.IsTrue(_formPresentationModel.IsToolPointerChecked());
        }

        // GetCanvasCursorTypeTest
        [TestMethod()]
        public void GetCanvasCursorTypeTest()
        {
            Assert.AreEqual(Cursors.Default, _formPresentationModel.GetCanvasCursorType());
            _formPresentationModel.ToolBarClick("Circle");
            Assert.AreEqual(Cursors.Cross, _formPresentationModel.GetCanvasCursorType());
        }

        // CanvasPressedTest
        [TestMethod()]
        public void CanvasPressedTest()
        {
            //_formPresentationModel
        }

        // CanvasReleasedTest
        [TestMethod()]
        public void CanvasReleasedTest()
        {
            //_formPresentationModel
        }

        // CanvasMovedTest
        [TestMethod()]
        public void CanvasMovedTest()
        {
            //_formPresentationModel
        }

        // DrawTest
        [TestMethod()]
        public void DrawTest()
        {
            //_formPresentationModel
        }
    }
}