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
    public class LineStateTests
    {
        Model _model;
        LineState _lineState;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _model = new Model();
            _model.AddShape(new Line(0, 0, 500, 500));

            _lineState = new LineState(_model);
        }

        // LineStateTest
        [TestMethod()]
        public void LineStateTest()
        {
            Assert.AreEqual("Line", _lineState.GetStateName());
        }

        // MouseDownTest
        [TestMethod()]
        public void MouseDownTest()
        {
            _lineState.MouseDown(300, 300);
            Assert.AreEqual("(300, 300), (300, 300)", _lineState.Hint.GetInfo());
        }
    }
}