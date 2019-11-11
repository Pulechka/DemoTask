using System;
using System.Collections.Generic;
using System.Text;

namespace FiguresDemo
{
	public class Circle : Figure
	{
		public Circle(double radius)
		{
			ValidateRadius(radius);
			Radius = radius;
		}

		private double _radius;
		public double Radius
		{
			get { return _radius; }
			set
			{
				ValidateRadius(value);
				_radius = value;
			}
		}

		public override double Area => Math.PI * Radius * Radius;

		private void ValidateRadius(double radius)
		{
			if (radius <= 0)
			{
				throw new ArgumentOutOfRangeException("Invalid value of Radius");
			}
		}
	}
}
