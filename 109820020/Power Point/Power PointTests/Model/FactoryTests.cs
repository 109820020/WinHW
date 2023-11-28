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
    public class FactoryTests
    {
        Factory _factory; 
        PrivateObject _factoryPrivate;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _factory = new Factory();
            _factoryPrivate = new PrivateObject(_factory);
        }

        // AddShape Test
        [TestMethod()]
        public void AddShapeTest()
        {
            Line line = new Line(0, 1, 2, 3);
            PrivateObject linePrivate = new PrivateObject(_factory.AddShape("線"));
            Assert.AreEqual(0, linePrivate.GetFieldOrProperty("_x1"));
        }
    }
}