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
    public class PointStateTests
    {
        Model _model;
        PointState _pointState;
        PrivateObject _pointStatePrivate;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _model.AddShape(new Line(0, 0, 500, 500));

            _pointState = new PointState(_model);
            _pointStatePrivate = new PrivateObject(_pointState);
        }

        // GetStateNameTest
        [TestMethod()]
        public void GetStateNameTest()
        {
            Assert.AreEqual("Pointer", _pointState.GetStateName());
        }

        // MouseDownTest
        [TestMethod()]
        public void MouseDownTest()
        {
            _pointState.MouseDown(250, 250);
            Assert.AreEqual(0, _pointStatePrivate.GetFieldOrProperty("_selectedIndex"));
            _pointState.MouseUp(250, 250);

            _pointState.MouseDown(850, 250);
            Assert.AreEqual(-1, _pointStatePrivate.GetFieldOrProperty("_selectedIndex"));
            _pointState.MouseUp(850, 250);
        }

        // MouseMoveTest
        [TestMethod()]
        public void MouseMoveTest()
        {
            _pointState.MouseDown(250, 250);
            _pointState.MouseMove(200, 500);
            Assert.AreEqual("(-50, 250), (450, 750)", _model.Shapes[0].GetInfo());
            _pointState.MouseUp(200, 500);

            _pointState.MouseDown(1000, 1000);
            Assert.AreEqual(-1, _pointStatePrivate.GetFieldOrProperty("_selectedIndex"));
        }

        // MouseUpTest
        [TestMethod()]
        public void MouseUpTest()
        {
            _pointState.MouseDown(250, 250);
            _pointState.MouseUp(200, 500);
            Assert.AreEqual("(-50, 250), (450, 750)", _model.Shapes[0].GetInfo());
        }

        // KeyDownTest
        [TestMethod()]
        public void KeyDownTest()
        {
            _pointState.KeyDown("Delete");
            Assert.AreEqual(1, _model.Shapes.Count());

            _pointState.MouseDown(250, 250);
            _pointState.MouseUp(250, 250);
            _pointState.KeyDown("Enter");
            Assert.AreEqual(1, _model.Shapes.Count());
            _pointState.KeyDown("Delete");
            Assert.AreEqual(0, _model.Shapes.Count());
        }

        // DrawTest
        [TestMethod()]
        public void DrawTest()
        {
            //IGraphics graphics = new FormGraphicsAdapter(new Graphics());
            //_pointState.Draw();
        }
    }
}