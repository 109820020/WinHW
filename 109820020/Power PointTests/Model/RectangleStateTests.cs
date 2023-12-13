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
    public class RectangleStateTests
    {
        Model _model;
        RectangleState _rectangleState;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _model.AddShape(new Rectangle(0, 0, 500, 500));

            _rectangleState = new RectangleState(_model);
        }

        // RectangleStateTest
        [TestMethod()]
        public void RectangleStateTest()
        {
            Assert.AreEqual("Rectangle", _rectangleState.GetStateName());
        }

        // MouseDownTest
        [TestMethod()]
        public void MouseDownTest()
        {
            _rectangleState.MouseDown(300, 300);
            Assert.AreEqual("(300, 300), (300, 300)", _rectangleState.Hint.GetInfo());
        }
    }
}