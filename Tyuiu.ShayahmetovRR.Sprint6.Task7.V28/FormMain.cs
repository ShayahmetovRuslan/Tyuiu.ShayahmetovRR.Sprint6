using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Tyuiu.ShayahmetovRR.Sprint6.Task7.V28.Lib;

namespace Tyuiu.ShayahmetovRR.Sprint6.Task7.V28
{
	public partial class FormMain : Form
	{
		public FormMain()
		{
			InitializeComponent();
			openFileDialogTask_SRR.Filter = "Значения, разделённые запятыми (*csv)|*.csv|Все файлы(*.*)|*.*";
			openFileDialogTask_SRR.Filter = "Значения, разделённые запятыми (*csv)|*.csv|Все файлы(*.*)|*.*";
		}

		static int rows;
		static int cols;
		static string openFilePath;

		DataService ds = new DataService();

		public static int[,] LoadFromFileData(string filePath)
		{
			string filedata = File.ReadAllText(filePath);
			filedata = filedata.Replace('\n', '\r');
			string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

			rows = lines.Length;
			cols = lines[0].Split(';').Length;

			int[,] arrayValues = new int[rows, cols];
			for (int r = 0; r < rows; r++)
			{
				string[] line_r = lines[r].Split(';');
				for (int c = 0; c < cols; c++)
				{
					arrayValues[r, c] = Convert.ToInt32(line_r[c]);
				}
			}
			return arrayValues;
		}

		private void buttonOpenFile_SRR_Click(object sender, EventArgs e)
		{
			openFileDialogTask_SRR.ShowDialog();
			openFilePath = openFileDialogTask_SRR.FileName;

			int[,] arrayValues = new int[rows, cols];

			arrayValues = LoadFromFileData(openFilePath);

			dataGridViewInput_SRR.ColumnCount = cols;
			dataGridViewInput_SRR.RowCount = rows;

			dataGridViewOutput_SRR.ColumnCount = cols;
			dataGridViewOutput_SRR.RowCount = rows;

			for (int i = 0; i < cols; i++)
			{
				dataGridViewInput_SRR.Columns[i].Width = 25;
				dataGridViewOutput_SRR.Columns[i].Width = 25;
			}

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					dataGridViewInput_SRR.Rows[r].Cells[c].Value = arrayValues[r, c];
				}
				arrayValues = LoadFromFileData(openFilePath);
				buttonDone_SRR.Enabled = true;
			}
		}

		private void buttonDone_SRR_Click(object sender, EventArgs e)
		{
			int[,] arrayValues = new int[rows, cols];
			arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

			for (int r = 0; r < rows; r++)
			{
				for (int c = 0; c < cols; c++)
				{
					dataGridViewOutput_SRR.Rows[r].Cells[c].Value = arrayValues[r, c];
				}
			}
			buttonSaveFile_SRR.Enabled = true;
		}

		private void buttonSaveFile_SRR_Click(object sender, EventArgs e)
		{
			saveFileDialogMatrix_SRR.FileName = "OutPutFileTask7V28.csv";
			saveFileDialogMatrix_SRR.InitialDirectory = Directory.GetCurrentDirectory();
			saveFileDialogMatrix_SRR.ShowDialog();

			string path = saveFileDialogMatrix_SRR.FileName;

			FileInfo fileinfo = new FileInfo(path);
			bool fileExists = fileinfo.Exists;

			if (fileExists)
			{
				File.Delete(path);
			}

			int rows = dataGridViewOutput_SRR.RowCount;
			int cols = dataGridViewOutput_SRR.ColumnCount;

			string str = "";
			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < cols; j++)
				{
					if (j != cols - 1)
					{
						str = str + dataGridViewOutput_SRR.Rows[i].Cells[j].Value + ";";
					}
					else
					{
						str = str + dataGridViewOutput_SRR.Rows[i].Cells[j].Value;
					}
				}
				File.AppendAllText(path, str + Environment.NewLine);
				str = "";
			}
		}

		private void buttonAboutStudent_SRR_Click(object sender, EventArgs e)
		{
			FormAbout formAbout = new FormAbout();
			formAbout.ShowDialog();
		}
		private void FormMain_Load(object sender, EventArgs e)
		{
			dataGridViewInput_SRR.ColumnCount = 50;
			dataGridViewOutput_SRR.ColumnCount = 50;

			dataGridViewOutput_SRR.RowCount = 50;
			dataGridViewInput_SRR.RowCount = 50;
		}
	}
}
