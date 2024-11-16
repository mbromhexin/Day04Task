using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	static public class Calculator
	{
		static public double Add(double x, double y)
		{
			return x + y;
		}

		static public double Multi(double x, double y)
		{
			return x * y;
		}

		static public double Subtract(double x, double y)
		{
			return x - y;
		}

		static public double Divide(double numerator, double denomirator)
		{
			if (denomirator == 0)
				return -1;
			return numerator / denomirator;
		}

	}
}
