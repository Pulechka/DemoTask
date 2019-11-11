using NUnit.Framework;
using System;

namespace FiguresDemo.Tests
{
	[TestFixture]
	public class CircleTests
	{
		[Test]
		public void Circle_WhenZeroRadius_ThrowsArgumentOutOfRangeException()
		{
			var radius = 0;

			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius), "Circle with zero Radius should not be created");
		}

		[Test]
		[TestCase(-0.25)]
		[TestCase(-3.1)]
		[TestCase(-124.978)]
		public void Circle_WhenNegativeRadius_ThrowsArgumentOutOfRangeException(double radius)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(radius), "Circle with negative Radius should not be created");
		}

		[Test]
		[TestCase(1, Math.PI)]
		[TestCase(2.7, Math.PI * 2.7 * 2.7)]
		[TestCase(123.57, Math.PI * 123.57 * 123.57)]
		public void Area_WhenValidCircle_ReturnsCorrectArea(double radius, double expectedArea)
		{
			var circle = new Circle(radius);
			var actualArea = circle.Area;

			Assert.AreEqual(expectedArea, actualArea, "Circle Area value is incorrect");
		}
	}
}