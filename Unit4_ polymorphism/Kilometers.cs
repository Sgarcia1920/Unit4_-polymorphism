using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4__polymorphism
{
	internal class Kilometers : Feet
	{
		public override double Convert(double value)
		{
			return value * 100000;
		}

		public override string ToString()
		{
			return base.ToString();
		}

	}
}
