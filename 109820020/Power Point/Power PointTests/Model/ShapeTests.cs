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
    public class ShapeTests
    {
        Shape _shape;
        PrivateObject _shapePrivate;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _shape = new Circle(4, 3, 2, 1);
            _shapePrivate = new PrivateObject(_shape);
        }

        // GetShapeNameTest
        [TestMethod()]
        public void GetShapeNameTest()
        {
            Assert.AreEqual("圓", _shape.GetShapeName());
        }

        // GetInfoTest
        [TestMethod()]
        public void GetInfoTest()
        {
            Assert.AreEqual("(2, 1), (4, 3)", _shape.GetInfo());
        }

        // ChangeSecondPointTest
        [TestMethod()]
        public void ChangeSecondPointTest()
        {
            _shape.ChangeSecondPoint(0, 1);
            Assert.AreEqual("(0, 1), (4, 3)", _shape.GetInfo());
        }

        // IsCursorInTest
        [TestMethod()]
        public void IsCursorInTest()
        {
            Assert.IsTrue(_shape.IsCursorIn(3, 2));
            Assert.IsFalse(_shape.IsCursorIn(0, 2));
        }

        // SelectTest
        [TestMethod()]
        public void SelectTest()
        {
            _shape.Select(3, 2);
            Assert.AreEqual(true, _shapePrivate.GetFieldOrProperty("_isSelect"));
            Assert.AreEqual(3, _shapePrivate.GetFieldOrProperty("_pressedDownPointX"));
            Assert.AreEqual(2, _shapePrivate.GetFieldOrProperty("_pressedDownPointY"));
            Assert.AreEqual(4, _shapePrivate.GetFieldOrProperty("_beforeMovingPointX1"));
            Assert.AreEqual(3, _shapePrivate.GetFieldOrProperty("_beforeMovingPointY1"));
            Assert.AreEqual(2, _shapePrivate.GetFieldOrProperty("_beforeMovingPointX2"));
            Assert.AreEqual(1, _shapePrivate.GetFieldOrProperty("_beforeMovingPointY2"));
        }

        // MoveShapeTest
        [TestMethod()]
        public void MoveShapeTest()
        {
            _shape.Select(3, 2);
            _shape.MoveShape(5, 5);
            Assert.AreEqual(true, _shapePrivate.GetFieldOrProperty("_isSelect"));
            Assert.AreEqual(6, _shapePrivate.GetFieldOrProperty("_x1"));
            Assert.AreEqual(6, _shapePrivate.GetFieldOrProperty("_y1"));
            Assert.AreEqual(4, _shapePrivate.GetFieldOrProperty("_x2"));
            Assert.AreEqual(4, _shapePrivate.GetFieldOrProperty("_y2"));
        }

        // CancelSelectTest
        [TestMethod()]
        public void CancelSelectTest()
        {
            Assert.AreEqual(false, _shapePrivate.GetFieldOrProperty("_isSelect"));
            _shape.Select(3, 2);
            Assert.AreEqual(true, _shapePrivate.GetFieldOrProperty("_isSelect"));
            _shape.CancelSelect();
            Assert.AreEqual(false, _shapePrivate.GetFieldOrProperty("_isSelect"));

        }

        // DrawSelectedBoxTest
        [TestMethod()]
        public void DrawSelectedBoxTest()
        {
            
        }

        // DrawTest
        [TestMethod()]
        public void DrawTest()
        {
            
        }
    }
}