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
    public class RectangleTests
    {
        Rectangle _rectangle;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _rectangle = new Rectangle(0, 1, 2, 3);
        }

        // RectangleTest
        [TestMethod()]
        public void RectangleTest()
        {
            Assert.AreEqual("矩形", _rectangle.GetShapeName());
            Assert.AreEqual("(0, 1), (2, 3)", _rectangle.GetInfo());
        }

        // DrawTest
        [TestMethod()]
        public void DrawTest()
        {
            
        }
    }
}