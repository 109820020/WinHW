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
    public class CircleStateTests
    {
        Model _model;
        CircleState _circleState;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _model.AddShape(new Circle(0, 0, 500, 500));

            _circleState = new CircleState(_model);
        }

        // CircleStateTest
        [TestMethod()]
        public void CircleStateTest()
        {
            Assert.AreEqual("Circle", _circleState.GetStateName());
        }

        // MouseDownTest
        [TestMethod()]
        public void MouseDownTest()
        {
            _circleState.MouseDown(300, 300);
            Assert.AreEqual("(300, 300), (300, 300)", _circleState.Hint.GetInfo());
        }
    }
}