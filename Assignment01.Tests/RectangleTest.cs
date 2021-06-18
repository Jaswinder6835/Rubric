using NUnit.Framework;
using Assignment01.Models;

namespace Assignment01.Tests
{
    [Parallelizable(ParallelScope.All)]
    public class RectangleTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        [TestCase(23, 61)]
        [TestCase(524981, 93651)]
        public void GetLength_Always_ReturnLength(int initialLength, int initialWidth)
        {
            var rectangle = new Rectangle(initialLength, initialWidth);
            Assert.AreEqual(initialLength, rectangle.GetLength());
        }

        [Test]
        [TestCase(44, 78, 64)]
        [TestCase(2031, 9624, 1023644)]
        public void SetLength_ForPositiveInteger_ChangeLength(int initialLength, int initialWidth, int lengthValue)
        {
            var rectangle = new Rectangle(initialLength, initialWidth);
            rectangle.SetLength(lengthValue);
            Assert.AreEqual(lengthValue, rectangle.GetLength());
        }

        [Test]
        [TestCase(3023, 52, 0)]
        [TestCase(63, 8025, -3621523)]
        [TestCase(1, 9624, -7)]
        public void SetLength_ForNonPositiveInteger_LengthNotChange(int initialLength, int initialWidth, int lengthValue)
        {
            var rectangle  = new Rectangle(initialLength, initialWidth);
            rectangle.SetLength(lengthValue);
            Assert.AreEqual(initialLength, rectangle.GetLength());
        }

        [Test]
        [TestCase(23, 61)]
        [TestCase(524981, 93651)]
        public void GetWidth_Always_ReturnWidth(int initialLength, int initialWidth)
        {
            var rectangle = new Rectangle(initialLength, initialWidth);
            Assert.AreEqual(initialWidth, rectangle.GetWidth());
        }

        [Test]
        [TestCase(44, 78, 64)]
        [TestCase(2031, 9624, 1023644)]
        public void SetWidth_ForPositiveInteger_ChangeWidth(int initialLength, int initialWidth, int widthValue)
        {
            var rectangle = new Rectangle(initialLength, initialWidth);
            rectangle.SetWidth(widthValue);
            Assert.AreEqual(widthValue, rectangle.GetWidth());
        }

        [Test]
        [TestCase(3023, 52, 0)]
        [TestCase(63, 8025, -3621523)]
        [TestCase(1, 9624, -7)]
        public void SetWidth_ForNonPositiveInteger_WidthNotChange(int initialLength, int initialWidth, int widthValue)
        {
            var rectangle = new Rectangle(initialLength, initialWidth);
            rectangle.SetWidth(widthValue);
            Assert.AreEqual(initialWidth, rectangle.GetWidth());
        }

        [Test]
        [TestCase(23, 93651, 187348)]
        [TestCase(3027, 9, 6072)]
        public void GetPerimeter_Always_ReturnParameterOfRectangle(int initialLength, int initialWidth, long perimeterOfRectangle)
        {
            var rectangle = new Rectangle(initialLength, initialWidth);
            Assert.AreEqual(perimeterOfRectangle, rectangle.GetPerimeter());
        }

        [Test]
        [TestCase(63, 8025, 505575)]
        [TestCase(524981, 936, 491382216)]
        public void GetArea_Always_ReturnAreaOfRectangle(int initialLength, int initialWidth, long areaOfRectangle)
        {
            var rectangle = new Rectangle(initialLength, initialWidth);
            Assert.AreEqual(areaOfRectangle, rectangle.GetArea());
        }
    }
}