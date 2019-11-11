using NUnit.Framework;
using FiguresDemo;
using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemo.Tests
{
	[TestFixture]
	public class TriangleTests
	{
		[Test]
		[TestCase(0, 2, 3)]
		[TestCase(1, 0, 3)]
		[TestCase(1, 2, 0)]
		public void Triangle_WhenZeroSide_ThrowsArgumentOutOfRangeException(double firstSide, double secondSide, double thirdSide)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide),
				"Triangle with zero side should not be created");
		}

		[Test]
		[TestCase(-1, 2, 3)]
		[TestCase(1, -2, 3)]
		[TestCase(1, 2, -3)]
		public void Triangle_WhenNegativeSide_ThrowsArgumentOutOfRangeException(double firstSide, double secondSide, double thirdSide)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide),
				"Triangle with negative side should not be created");
		}

		[Test]
		[TestCase(1, 2, 5)]
		[TestCase(5, 2, 1)]
		[TestCase(2, 5, 1)]
		public void Triangle_WhenSumOfTwoSidesLessThanOtherSide_ThrowsArgumentOutOfRangeException(double firstSide, double secondSide, double thirdSide)
		{
			Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(firstSide, secondSide, thirdSide),
				"Triangle with invalid state should not be created");
		}

		[Test]
		[TestCase(3, 4, 5, 6)]
		[TestCase(6, 8, 10, 24)]
		[TestCase(7, 5, 6, 14.696938456699069)]
		public void Area_WhenTrianleIsValid_ReturnsCorrectArea(double firstSide, double secondSide, double thirdSide, double expectedArea)
		{
			var triangle = new Triangle(firstSide, secondSide, thirdSide);
			var actualArea = triangle.Area;

			Assert.AreEqual(expectedArea, actualArea, "Trianle Area value is incorrect");
		}

		[Test()]
		[TestCase(4, 2, 5)]
		[TestCase(7, 6, 2)]
		[TestCase(8, 5, 4)]
		public void IsRight_ReturnsFalse(double firstSide, double secondSide, double thirdSide)
		{
			var triangle = new Triangle(firstSide, secondSide, thirdSide);

			Assert.IsFalse(triangle.IsRight, "IsRight should be False for specified triangle");
		}

		[Test()]
		[TestCase(3, 4, 5)]
		[TestCase(6, 8, 10)]
		[TestCase(12, 16, 20)]
		public void IsRight_ReturnsTrue(double firstSide, double secondSide, double thirdSide)
		{
			var triangle = new Triangle(firstSide, secondSide, thirdSide);

			Assert.IsTrue(triangle.IsRight, "IsRight should be True for specified triangle");
		}
	}
}