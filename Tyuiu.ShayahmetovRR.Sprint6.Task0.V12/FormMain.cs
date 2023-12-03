using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Tyuiu.ShayahmetovRR.Sprint6.Task0.V12.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task0.V12
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		private void buttonDone_SRR_Click(object sender, EventArgs e)
		{
			DataService ds = new DataService();
			try
			{
				textBoxResult_SRR.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarX_SRR.Text)));
			}
			catch
			{
				MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void groupBoxInputData_SRR_Enter(object sender, EventArgs e)
		{

		}

		private void buttonStudentInfo_SRR_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Таск 0 выполнил студент группы АСОиУб-23-1 Шаяхметов Руслан Раилевич :)", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Question);
		}

		private void textBoxVarX_SRR_TextChanged(object sender, EventArgs e)
		{

		}
	}
}