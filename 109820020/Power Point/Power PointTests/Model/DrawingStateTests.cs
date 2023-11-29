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
    public class DrawingStateTests
    {
        Model _model;
        DrawingState _drawingState;
        PrivateObject _drawingStatePrivate;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model(); 
            _model.AddShape(new Line(0, 0, 500, 500));

            _drawingState = new LineState(_model);
            _drawingStatePrivate = new PrivateObject(_drawingState);
        }

        // GetStateNameTest
        [TestMethod()]
        public void GetStateNameTest()
        {
            Assert.AreEqual("Line", _drawingState.GetStateName());
        }

        // MouseMoveTest
        [TestMethod()]
        public void MouseMoveTest()
        {
            _drawingState.MouseDown(700, 700);
            _drawingState.MouseMove(500, 500);
            Assert.AreEqual("(500, 500), (700, 700)", _drawingState.Hint.GetInfo());
        }

        // MouseUpTest
        [TestMethod()]
        public void MouseUpTest()
        {
            _drawingState.MouseDown(700, 700);
            _drawingState.MouseUp(500, 500);
            Assert.AreEqual("(500, 500), (700, 700)", _model.Shapes[1].GetInfo());
        }

        // KeyDownTest
        [TestMethod()]
        public void KeyDownTest()
        {
            _drawingState.KeyDown("Delete");
        }

        // DrawTest
        [TestMethod()]
        public void DrawTest()
        {
        }
    }
}