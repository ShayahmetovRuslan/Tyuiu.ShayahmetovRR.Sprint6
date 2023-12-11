namespace Tyuiu.ShayahmetovRR.Sprint6.Task5.V20
{
	partial class FormMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.groupBoxOutput_SRR = new System.Windows.Forms.GroupBox();
			this.dataGridViewOutput_SRR = new System.Windows.Forms.DataGridView();
			this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonDone_SRR = new System.Windows.Forms.Button();
			this.buttonAboutStudent_SRR = new System.Windows.Forms.Button();
			this.buttonOpenFile_SRR = new System.Windows.Forms.Button();
			this.chartFunction_SRR = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.groupBoxOutput_SRR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SRR)).BeginInit();
			this.groupBoxCondition_SRR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartFunction_SRR)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxOutput_SRR
			// 
			this.groupBoxOutput_SRR.Controls.Add(this.dataGridViewOutput_SRR);
			this.groupBoxOutput_SRR.Location = new System.Drawing.Point(13, 82);
			this.groupBoxOutput_SRR.Name = "groupBoxOutput_SRR";
			this.groupBoxOutput_SRR.Size = new System.Drawing.Size(200, 356);
			this.groupBoxOutput_SRR.TabIndex = 0;
			this.groupBoxOutput_SRR.TabStop = false;
			this.groupBoxOutput_SRR.Text = "Вывод данных";
			// 
			// dataGridViewOutput_SRR
			// 
			this.dataGridViewOutput_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOutput_SRR.ColumnHeadersVisible = false;
			this.dataGridViewOutput_SRR.Location = new System.Drawing.Point(7, 20);
			this.dataGridViewOutput_SRR.Name = "dataGridViewOutput_SRR";
			this.dataGridViewOutput_SRR.RowHeadersVisible = false;
			this.dataGridViewOutput_SRR.Size = new System.Drawing.Size(187, 330);
			this.dataGridViewOutput_SRR.TabIndex = 0;
			// 
			// groupBoxCondition_SRR
			// 
			this.groupBoxCondition_SRR.Controls.Add(this.label1);
			this.groupBoxCondition_SRR.Location = new System.Drawing.Point(13, 12);
			this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
			this.groupBoxCondition_SRR.Size = new System.Drawing.Size(399, 65);
			this.groupBoxCondition_SRR.TabIndex = 1;
			this.groupBoxCondition_SRR.TabStop = false;
			this.groupBoxCondition_SRR.Text = "Условие";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(385, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Прочитать данные из файла InPutFileTask5V20.txt. Вывести в DataGridView\r\nвсе цифр" +
    "ы, кратные 2.";
			// 
			// buttonDone_SRR
			// 
			this.buttonDone_SRR.BackColor = System.Drawing.Color.Green;
			this.buttonDone_SRR.Location = new System.Drawing.Point(419, 13);
			this.buttonDone_SRR.Name = "buttonDone_SRR";
			this.buttonDone_SRR.Size = new System.Drawing.Size(119, 64);
			this.buttonDone_SRR.TabIndex = 2;
			this.buttonDone_SRR.Text = "Выполнить";
			this.buttonDone_SRR.UseVisualStyleBackColor = false;
			this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
			// 
			// buttonAboutStudent_SRR
			// 
			this.buttonAboutStudent_SRR.BackColor = System.Drawing.SystemColors.HotTrack;
			this.buttonAboutStudent_SRR.Location = new System.Drawing.Point(544, 13);
			this.buttonAboutStudent_SRR.Name = "buttonAboutStudent_SRR";
			this.buttonAboutStudent_SRR.Size = new System.Drawing.Size(119, 64);
			this.buttonAboutStudent_SRR.TabIndex = 3;
			this.buttonAboutStudent_SRR.Text = "Справка";
			this.buttonAboutStudent_SRR.UseVisualStyleBackColor = false;
			this.buttonAboutStudent_SRR.Click += new System.EventHandler(this.buttonAboutStudent_SRR_Click);
			// 
			// buttonOpenFile_SRR
			// 
			this.buttonOpenFile_SRR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.buttonOpenFile_SRR.Location = new System.Drawing.Point(669, 13);
			this.buttonOpenFile_SRR.Name = "buttonOpenFile_SRR";
			this.buttonOpenFile_SRR.Size = new System.Drawing.Size(119, 64);
			this.buttonOpenFile_SRR.TabIndex = 4;
			this.buttonOpenFile_SRR.Text = "Открыть файл";
			this.buttonOpenFile_SRR.UseVisualStyleBackColor = false;
			this.buttonOpenFile_SRR.Click += new System.EventHandler(this.buttonOpenFile_SRR_Click);
			// 
			// chartFunction_SRR
			// 
			chartArea7.Name = "ChartArea1";
			this.chartFunction_SRR.ChartAreas.Add(chartArea7);
			legend7.Name = "Legend1";
			this.chartFunction_SRR.Legends.Add(legend7);
			this.chartFunction_SRR.Location = new System.Drawing.Point(219, 83);
			this.chartFunction_SRR.Name = "chartFunction_SRR";
			series7.ChartArea = "ChartArea1";
			series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series7.Legend = "Legend1";
			series7.Name = "Series1";
			this.chartFunction_SRR.Series.Add(series7);
			this.chartFunction_SRR.Size = new System.Drawing.Size(569, 355);
			this.chartFunction_SRR.TabIndex = 5;
			this.chartFunction_SRR.Text = "chart1";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.chartFunction_SRR);
			this.Controls.Add(this.buttonOpenFile_SRR);
			this.Controls.Add(this.buttonAboutStudent_SRR);
			this.Controls.Add(this.buttonDone_SRR);
			this.Controls.Add(this.groupBoxCondition_SRR);
			this.Controls.Add(this.groupBoxOutput_SRR);
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Спринт 6 | Таск 5 | Вариант 20 | Шаяхметов Р. Р.";
			this.groupBoxOutput_SRR.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SRR)).EndInit();
			this.groupBoxCondition_SRR.ResumeLayout(false);
			this.groupBoxCondition_SRR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartFunction_SRR)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxOutput_SRR;
		private System.Windows.Forms.DataGridView dataGridViewOutput_SRR;
		private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
		private System.Windows.Forms.Button buttonDone_SRR;
		private System.Windows.Forms.Button buttonAboutStudent_SRR;
		private System.Windows.Forms.Button buttonOpenFile_SRR;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SRR;
		private System.Windows.Forms.Label label1;
	}
}

