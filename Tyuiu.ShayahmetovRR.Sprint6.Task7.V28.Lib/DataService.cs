using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task7.V28.Lib
{
	public class DataService : ISprint6Task7V28
	{
		public int[,] GetMatrix(int[,] matrix)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			int nrow = 6;

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (matrix[nrow, j] != 13)
					{
						matrix[nrow, j] = 0;
					}
				}
			}
			return matrix;
		}
	}
}
