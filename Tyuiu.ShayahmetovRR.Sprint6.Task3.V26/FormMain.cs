using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShayahmetovRR.Sprint6.Task3.V26.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task3.V26
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		DataService ds = new DataService();
		int[,] matrix = new int[5, 5] { { 16, 19, 17, 2, 8 },
									 { -17, 8, -17, -8, 1 },
									 { -7, 17, -2, 1, -3 },
									 {-12, 0, -17, 15, 6 },
									 { 17, -6, -17, 18, -19 } };

		private void FormMain_Load(object sender, EventArgs e)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			dataGridViewCondition_SSR.ColumnCount = cols;
			dataGridViewCondition_SSR.RowCount = rows;

			for (int i = 0; i < cols; i++)
			{
				dataGridViewCondition_SSR.Columns[i].Width = 25;
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					dataGridViewCondition_SSR.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
				}
			}
		}

		private void buttonDone_SSR_Click(object sender, EventArgs e)
		{
			int rows = matrix.GetLength(0);
			int cols = matrix.GetLength(1);

			dataGridViewOutput_SSR.ColumnCount = cols;
			dataGridViewOutput_SSR.RowCount = rows;

			int[,] newMtrx = ds.Calculate(matrix);

			for (int i = 0; i < cols; i++)
			{
				dataGridViewOutput_SSR.Columns[i].Width = 25;
			}

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					dataGridViewOutput_SSR.Rows[i].Cells[j].Value = Convert.ToString(newMtrx[i, j]);
				}
			}
		}

		private void buttonAboutStudent_SSR_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 3 выполнил студент группы АСОиУб-23-1 Шаяхметов Руслан Раилевич :)", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}
	}
}
