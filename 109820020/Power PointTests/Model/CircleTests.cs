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
    public class CircleTests
    {
        Circle _circle;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _circle = new Circle(0, 1, 2, 3);
        }

        // CircleTest
        [TestMethod()]
        public void CircleTest()
        {
            Assert.AreEqual("圓", _circle.GetShapeName());
            Assert.AreEqual("(0, 1), (2, 3)", _circle.GetInfo());
        }

        // DrawTest
        [TestMethod()]
        public void DrawTest()
        {
            
        }
    }
}