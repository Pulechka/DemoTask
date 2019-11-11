using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FiguresDemo
{
	public class Triangle : Figure
	{
		public Triangle(double firstSide, double secondSide, double thirdSide)
		{
			ValidateSide(firstSide);
			ValidateSide(secondSide);
			ValidateSide(thirdSide);
			ValidateState(firstSide, secondSide, thirdSide);

			_firstSide = firstSide;
			_secondSide = secondSide;
			_thirdSide = thirdSide;
		}

		private double _firstSide;
		public double FirstSide
		{
			get { return _firstSide; }
			set
			{
				ValidateSide(value);
				ValidateState(value, SecondSide, ThirdSide);

				_firstSide = value;
			}
		}

		private double _secondSide;
		public double SecondSide
		{
			get { return _secondSide; }
			set
			{
				ValidateSide(value);
				ValidateState(FirstSide, value, ThirdSide);

				_secondSide = value;
			}
		}

		private double _thirdSide;
		public double ThirdSide
		{
			get { return _thirdSide; }
			set
			{
				ValidateSide(value);
				ValidateState(FirstSide, SecondSide, value);

				_thirdSide = value;
			}
		}


		public override double Area
		{
			get
			{
				var semiperimeter = (FirstSide + SecondSide + ThirdSide) / 2;
				return Math.Sqrt(semiperimeter * (semiperimeter - FirstSide) * (semiperimeter - SecondSide) * (semiperimeter - ThirdSide));
			}
		}

		public bool IsRight
		{
			get
			{
				var firstSideSquare = FirstSide * FirstSide;
				var secondSideSquare = SecondSide * SecondSide;
				var thirdSideSquare = ThirdSide * ThirdSide;

				return firstSideSquare == secondSideSquare + thirdSideSquare
					|| secondSideSquare == firstSideSquare + thirdSideSquare
					|| thirdSideSquare == firstSideSquare + secondSideSquare;
			}
		}

		private void ValidateSide(double side)
		{
			if (side <= 0)
			{
				throw new ArgumentOutOfRangeException("Invalid value of triangle side");
			}
		}

		private void ValidateState(double firstSide, double secondSide, double thirdSide)
		{
			if (firstSide + secondSide <= thirdSide
				|| secondSide + thirdSide <= firstSide
				|| thirdSide + firstSide <= secondSide)
			{
				throw new ArgumentOutOfRangeException("Can't set triangle state to invalid");
			}
		}
	}
}
