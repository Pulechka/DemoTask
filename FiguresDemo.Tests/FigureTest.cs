using FiguresDemo.Tests.Fakes;
using NUnit.Framework;

namespace FiguresDemo.Tests
{
	[TestFixture]
	public class FigureTest
	{
		[Test, TestCaseSource(typeof(FigureTestCases), nameof(FigureTestCases.CorrectArea))]
		public double Figure_WhenUnknownFigure_CorrectArea(Figure unknownFigure)
		{
			return unknownFigure.Area;
		}
	}
}
