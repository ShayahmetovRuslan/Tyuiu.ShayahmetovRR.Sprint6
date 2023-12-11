﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;
using System.IO;
using System.Xml.Schema;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task5.V20.Lib
{
	public class DataService : ISprint6Task5V20
	{
		public int len = 0;
		public double[] LoadFromDataFile(string path)
		{
			using (StreamReader reader = new StreamReader(path))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					len++;
				}
			}

			double[] numsArray = new double[len];

			int index = 0;
			using(StreamReader reader = new StreamReader(path))
			{
				string line;
				while ((line = reader.ReadLine()) != null)
				{
					numsArray[index] = Convert.ToDouble(line);
					index++;
				}
			}

			numsArray = numsArray.Where(x => x % 2 == 0).ToArray();

			return numsArray;
		}
	}
}
