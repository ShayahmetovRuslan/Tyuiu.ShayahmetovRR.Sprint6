using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShayahmetovRR.Sprint6.Task5.V20;
using Tyuiu.ShayahmetovRR.Sprint6.Task5.V20.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task5.V20
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		DataService ds = new DataService();
		string path = @"C:\Users\zorg0\source\repos\Tyuiu.ShayahmetovRR.Sprint6\InPutFileTask5V20.txt";

		private void buttonDone_SRR_Click(object sender, EventArgs e)
		{
			dataGridViewOutput_SRR.ColumnCount = 2;
			dataGridViewOutput_SRR.Columns[0].Width = 20;
			dataGridViewOutput_SRR.Columns[1].Width = 50;

			this.chartFunction_SRR.ChartAreas[0].AxisX.Title = "Ось X";
			this.chartFunction_SRR.ChartAreas[0].AxisY.Title = "Ось Y";

			chartFunction_SRR.Series[0].Points.Clear();

			double[] numsMass = new double[ds.len];

			numsMass = ds.LoadFromDataFile(path);

			for (int i = 0; i < numsMass.Length; i++)
			{
				dataGridViewOutput_SRR.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
				chartFunction_SRR.Series[0].Points.AddXY(i, numsMass[i]);
			}
		}

		private void buttonOpenFile_SRR_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process txt  = new System.Diagnostics.Process();
			txt.StartInfo.FileName = "notepad.exe";
			txt.StartInfo.Arguments = path;
			txt.Start();
		}

		private void buttonAboutStudent_SRR_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 5 выполнил студент группы АСОиУб-23-1 Шаяхметов Руслан Раилевич :)", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}
	}
}
