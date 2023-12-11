
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.ShayahmetovRR.Sprint6.Task5.V20.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task5.V20.Test
{
	[TestClass]
	public class DataServiceTest
	{
		[TestMethod]
		public void TestMethod1()
		{
			DataService ds = new DataService();
			string path = @"C:\Users\zorg0\source\repos\Tyuiu.ShayahmetovRR.Sprint6\InPutFileTask5V20.txt";

			double[] wait = {0, 12, 0};
			double[] res = ds.LoadFromDataFile(path);

			CollectionAssert.AreEqual(res, wait);
		}
	}
}
