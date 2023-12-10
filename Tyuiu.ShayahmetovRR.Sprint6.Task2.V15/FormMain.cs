using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShayahmetovRR.Sprint6.Task2.V15.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task2.V15
{
	public partial class FormMain : Form
	{
		DataService ds = new DataService();
		public FormMain()
		{
			InitializeComponent();
		}


		private void buttonDone_SRR_Click(object sender, EventArgs e)
		{
				int startStep = Convert.ToInt32(textBoxStartValue_SRR.Text);
				int stopStep = Convert.ToInt32(textBoxStopValue_SRR.Text);

				int len = ds.GetMassFunction(startStep, stopStep).Length;

				double[] valueArray;
				valueArray = new double[len];

				valueArray = ds.GetMassFunction(startStep, stopStep);

				this.chartFunction_SSR.ChartAreas[0].AxisX.Title = "Ось X";
				this.chartFunction_SSR.ChartAreas[0].AxisY.Title = "Ось Y";

				for (int i = 0; i < len; i++)
				{
					this.dataGridViewResult_SRR.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));

					this.chartFunction_SSR.Series[0].Points.AddXY(startStep, valueArray[i]);

					startStep++;
				}
		}

		private void buttonInfo_SRR_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 2 выполнил студент группы АСОиУб-23-1 Шаяхметов Руслан Раилевич :)", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}
	}
}
