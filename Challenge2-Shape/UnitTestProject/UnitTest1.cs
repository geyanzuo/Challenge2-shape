using NUnit.Framework;
using Challenge2_Shape;


namespace UnitTestProject
{
    [TestFixture]
    public class UnitTest1
    {
        Square sq1 { get; set; }
        Rectangle re1 { get; set; }
        Equilateral eq1 { get; set; }
        Rightangle ri1 { get; set; }
        Circle ci1 { get; set; }


        Square sq2 { get; set; }
        Rectangle re2 { get; set; }
        Equilateral eq2 { get; set; }
        Rightangle ri2 { get; set; }
        Circle ci2 { get; set; }


        Square sq3{ get; set; }
        Rectangle re3 { get; set; }
        Equilateral eq3 { get; set; }
        Rightangle ri3 { get; set; }
        Circle ci3 { get; set; }

        [SetUp]
        public void Initial()
        {
            sq1 = new Square(5, "Blue");
            re1 = new Rectangle(5, 10, "Blue");
            eq1 = new Equilateral(5, "Blue");
            ri1 = new Rightangle(5, 10, "Blue");
            ci1 = new Circle(5, "Blue");

            sq2 = new Square(15, "Blue");
            re2 = new Rectangle(4, 6, "Blue");
            eq2 = new Equilateral(15, "Blue");
            ri2 = new Rightangle(4, 6, "Blue");
            ci2 = new Circle(15, "Blue");

            sq3 = new Square(7, "Blue");
            re3 = new Rectangle(9, 7, "Blue");
            eq3 = new Equilateral(7, "Blue");
            ri3 = new Rightangle(9, 7, "Blue");
            ci3 = new Circle(7, "Blue");

        }

        [Test]
        public void SquareTest()
        {
            double area = 25;
            double perimeter = 20;

            Assert.AreEqual(area, sq1.GetArea());
            Assert.AreEqual(perimeter, sq1.GetPerimeter());


            area = 225;
            perimeter = 60;

            Assert.AreEqual(area, sq2.GetArea());
            Assert.AreEqual(perimeter, sq2.GetPerimeter());


            area = 49;
            perimeter = 28;

            Assert.AreEqual(area, sq3.GetArea());
            Assert.AreEqual(perimeter, sq3.GetPerimeter());


           
        }

        [Test]
        public void RectangleTest()
        {
            double area = 50;
            double perimeter = 30;

            Assert.AreEqual(area, re1.GetArea());
            Assert.AreEqual(perimeter, re1.GetPerimeter());


            area = 24;
            perimeter = 20;

            Assert.AreEqual(area, re2.GetArea());
            Assert.AreEqual(perimeter, re2.GetPerimeter());


            area = 63;
            perimeter = 32;

            Assert.AreEqual(area, re3.GetArea());
            Assert.AreEqual(perimeter, re3.GetPerimeter());

        }

        [Test]
        public void EquailateralTest()
        {
            double area = 10.83;
            double perimeter = 15;

            Assert.AreEqual(area, eq1.GetArea());
            Assert.AreEqual(perimeter, eq1.GetPerimeter());


            area = 97.43;
            perimeter = 45;

            Assert.AreEqual(area, eq2.GetArea());
            Assert.AreEqual(perimeter, eq2.GetPerimeter());


            area = 21.22;
            perimeter = 21;

            Assert.AreEqual(area, eq3.GetArea());
            Assert.AreEqual(perimeter, eq3.GetPerimeter());
        }

        [Test]
        public void RightAngleTest()
        {
            double area = 25;
            double perimeter = 26.18;

            Assert.AreEqual(area, ri1.GetArea());
            Assert.AreEqual(perimeter, ri1.GetPerimeter());


            area = 12;
            perimeter = 17.21;

            Assert.AreEqual(area,ri2.GetArea());
            Assert.AreEqual(perimeter, ri2.GetPerimeter());


            area = 31.5;
            perimeter = 27.4;

            Assert.AreEqual(area, ri3.GetArea());
            Assert.AreEqual(perimeter, ri3.GetPerimeter());
        }

        [Test]
        public void CircleTest()
        {
            double area = 78.54;
            double perimeter = 31.42;

            Assert.AreEqual(area, ci1.GetArea());
            Assert.AreEqual(perimeter, ci1.GetPerimeter());


            area = 706.86;
            perimeter = 94.25;

            Assert.AreEqual(area, ci2.GetArea());
            Assert.AreEqual(perimeter, ci2.GetPerimeter());


            area = 153.94;
            perimeter = 43.98;

            Assert.AreEqual(area, ci3.GetArea());
            Assert.AreEqual(perimeter, ci3.GetPerimeter());
        }
    }
}
