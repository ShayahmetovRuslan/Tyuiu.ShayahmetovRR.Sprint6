using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task4.V19.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void ValidCheck()
		{
			int startValue = -5;
			int stopValue = 5;

			int len = stopValue - startValue + 1;
			double[] wait = new double[len];

			wait[0] = 23.61;
			wait[1] = 16.08;
			wait[2] = 7.84;
			wait[3] = 4.58;
			wait[4] = 2.88;
			wait[5] = 0.75;
			wait[6] = -4.47;
			wait[7] = -9.46;
			wait[8] = -7.41;
			wait[9] = -6.16;
			wait[10] = -7.29;
		}
	}
}
