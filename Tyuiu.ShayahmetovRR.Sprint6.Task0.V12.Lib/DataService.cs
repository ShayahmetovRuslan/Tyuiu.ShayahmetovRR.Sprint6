using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task0.V12.Lib
{
	public class DataService : ISprint6Task0V12
	{
		public double Calculate(int x)
		{
			double res = (Math.Pow(x, 2) + 1) / (Math.Pow((4 * x*x - 3), 0.5));
			return Math.Round(res, 3);
		}
	}
}
