using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4__polymorphism
{
	internal class Feet : Unit
	{
		private double user_value;

		public double Value
		{
			get { return user_value; }
			set { user_value = value; }
		}


		public Feet()
		{
			this.user_value = 0.0;

		}
		public Feet(double v)
		{
			this.user_value = v;

		}

		public override double Convert(double value)
		{
			return value * 30.48;
		}

		public override string ToString()
		{
			return "The result is " + Convert(user_value);
		}

	}
}