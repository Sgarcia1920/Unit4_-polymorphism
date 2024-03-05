using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit4__polymorphism
{
	internal class Conversion_implementation : Conversions
	{
		public double feet_to_cm(double ft)
		{
			return ft * 30.48; 
		}

	
		public double kilometers_to_cm(double km)
		{
			return km * 100000; 
		}

	}
}