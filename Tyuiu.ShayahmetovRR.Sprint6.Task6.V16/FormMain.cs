using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ShayahmetovRR.Sprint6.Task6.V16.Lib;
using System.IO;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task6.V16
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
		}

		string openFilePath;
		DataService ds = new DataService();

		private void buttonDone_SRR_Click(object sender, EventArgs e)
		{
			string str = "b";
			textBoxOutput_SRR.Text = ds.CollectTextFromFile(str, openFilePath);
		}

		private void buttonOpenFile_SRR_Click(object sender, EventArgs e)
		{
			try
			{
				openFileDialog_SRR.ShowDialog();
				openFilePath = openFileDialog_SRR.FileName;
				textBoxInput_SRR.Text = File.ReadAllText(openFilePath);
				groupBoxInput_SRR.Text += " " + openFileDialog_SRR.FileName;
				buttonDone_SRR.Enabled = true;
			}
			catch
			{
				MessageBox.Show("Что-то пошло не так. Попробуйте еще раз.");
			}
		}

		private void buttonAboutStudent_SRR_Click(object sender, EventArgs e)
		{
			FormAbout formAbout = new FormAbout();
			formAbout.ShowDialog();
		}
	}
}
