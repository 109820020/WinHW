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
    public class ShapesTests
    {
        Shapes _shapes;
        PrivateObject _shapesPrivate;

        // Init test
        [TestInitialize()]
        public void Initialize()
        {
            _shapes = new Shapes();
            _shapesPrivate = new PrivateObject(_shapes);
        }

        // ShapesTest
        [TestMethod()]
        public void ShapesTest()
        {
            Assert.AreEqual(0, _shapes.ShapeList.Count());
        }

        // AddShapeTest (string)
        [TestMethod()]
        public void AddShapeTest()
        {
            Assert.AreEqual(0, _shapes.ShapeList.Count());
            _shapes.AddShape("線");
            Assert.AreEqual(1, _shapes.ShapeList.Count());
            Assert.AreEqual("線", _shapes.ShapeList[0].GetShapeName());
        }

        // AddShapeTest (Shape)
        [TestMethod()]
        public void AddShapeTest1()
        {
            Assert.AreEqual(0, _shapes.ShapeList.Count());
            Shape shape = new Line(0, 1, 2, 3);
            _shapes.AddShape(shape);
            Assert.AreEqual(1, _shapes.ShapeList.Count());
            Assert.AreEqual(shape, _shapes.ShapeList[0]);
        }

        // DeleteShapeTest
        [TestMethod()]
        public void DeleteShapeTest()
        {
            Assert.AreEqual(0, _shapes.ShapeList.Count());
            Shape shape = new Line(0, 1, 2, 3);
            _shapes.AddShape(shape);
            Assert.AreEqual(1, _shapes.ShapeList.Count());
            _shapes.DeleteShape(0);
            Assert.AreEqual(0, _shapes.ShapeList.Count());
        }

        // DrawAllShapesTest
        [TestMethod()]
        public void DrawAllShapesTest()
        {
        }

        // SelectShapeTest
        [TestMethod()]
        public void SelectShapeTest()
        {
            _shapes.AddShape(new Line(0, 0, 500, 500));
            _shapes.AddShape(new Rectangle(250, 250, 500, 500));
            _shapes.AddShape(new Circle(250, 0, 600, 400));
            Assert.AreEqual(-1, _shapes.SelectShape(200, 700));
            Assert.AreEqual(2, _shapes.SelectShape(350, 350));
            Assert.AreEqual(1, _shapes.SelectShape(450, 450));
            Assert.AreEqual(0, _shapes.SelectShape(50, 50));
        }

        // MoveShapeTest MoveShape(int index, int offsetX, int offsetY)
        [TestMethod()]
        public void MoveShapeTest()
        {
            _shapes.AddShape(new Line(0, 0, 500, 500));
            _shapes.AddShape(new Rectangle(250, 250, 500, 500));

            _shapes.MoveShape(0, 250, 100);
            Assert.AreEqual("(250, 100), (250, 100)", _shapes.ShapeList[0].GetInfo());
        }
    }
}