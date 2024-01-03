using Microsoft.VisualStudio.TestTools.UnitTesting;
using Power_Point;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Point.Tests
{
    [TestClass()]
    public class ModelTests
    {
        // Graphics _graphics;
        Model _model;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            //Form1 form = new Form1(model, new FormPresentationModel(model));
            //_graphics = form.CreateGraphics();
        }

        // AddShapeTest
        [TestMethod()]
        public void AddShapeTest()
        {
            _model.AddShape("線");
            Assert.AreEqual("線", _model.Shapes[0].GetShapeName());
        }

        // AddShapeTest1
        [TestMethod()]
        public void AddShapeTest1()
        {
            _model.AddShape(new Line(0, 1, 2, 3));
            Assert.AreEqual("線", _model.Shapes[0].GetShapeName());
        }

        // DeleteShapeTest
        [TestMethod()]
        public void DeleteShapeTest()
        {
            _model.AddShape(new Line(0, 1, 2, 3));
            Assert.AreEqual(1, _model.Shapes.Count);
            _model.DeleteShape(0);
            Assert.AreEqual(0, _model.Shapes.Count);
        }

        // ChangeStateTest
        [TestMethod()]
        public void ChangeStateTest()
        {
            Assert.AreEqual("Pointer", _model.GetToolState());
            _model.ChangeState("Line");
            Assert.AreEqual("Line", _model.GetToolState());
        }

        // GetToolStateTest
        [TestMethod()]
        public void GetToolStateTest()
        {
            Assert.AreEqual("Pointer", _model.GetToolState());
        }

        // SelectShapeTest
        [TestMethod()]
        public void SelectShapeTest()
        {
        }

        // MoveShapeTest
        [TestMethod()]
        public void MoveShapeTest()
        {
        }

        // KeyDownTest
        [TestMethod()]
        public void KeyDownTest()
        {
        }

        // CanvasPressedTest
        [TestMethod()]
        public void CanvasPressedTest()
        {
        }

        // CanvasMovedTest
        [TestMethod()]
        public void CanvasMovedTest()
        {
        }

        // CanvasReleasedTest
        [TestMethod()]
        public void CanvasReleasedTest()
        {
        }

        // DrawTest
        [TestMethod()]
        public void DrawTest()
        {
        }
    }
}