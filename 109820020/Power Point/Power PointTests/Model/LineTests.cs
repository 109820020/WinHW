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
    public class LineTests
    {
        Line _line;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _line = new Line(0, 1, 2, 3);
        }

        // LineTest
        [TestMethod()]
        public void LineTest()
        {
            Assert.AreEqual("線", _line.GetShapeName());
            Assert.AreEqual("(0, 1), (2, 3)", _line.GetInfo());
        }

        // DrawTest
        [TestMethod()]
        public void DrawTest()
        {
            
        }
    }
}