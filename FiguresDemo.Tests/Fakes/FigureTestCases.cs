using NUnit.Framework;
using System;
using System.Collections.Generic;

namespace FiguresDemo.Tests.Fakes
{
	public static class FigureTestCases
	{
		public static IEnumerable<TestCaseData> CorrectArea
		{
			get
			{
				yield return new TestCaseData(new Circle(1)).Returns(Math.PI);
				yield return new TestCaseData(new Triangle(3, 4, 5)).Returns(6);
				yield return new TestCaseData(new Circle(2.7)).Returns(Math.PI * 2.7 * 2.7);
			} 
		}
	}
}
