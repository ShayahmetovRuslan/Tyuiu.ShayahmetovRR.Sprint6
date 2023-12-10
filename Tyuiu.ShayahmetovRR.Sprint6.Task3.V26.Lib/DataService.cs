using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task3.V26.Lib
{
	public class DataService : ISprint6Task3V26
	{
		public int[,] Calculate(int[,] matrix)
		{
			matrix = new int[5, 5] { { 16, 19, 17, 2, 8 },
									 { -17, 8, -17, -8, 1 },
									 { -7, 17, -2, 1, -3 },
									 {-12, 0, -17, 15, 6 },
									 { 17, -6, -17, 18, -19 } };

			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (matrix[2, j] % 2 == 0)
					{
						matrix[2, j] = 0;
					}
				}
			}
			return matrix;
		}
	}
}
