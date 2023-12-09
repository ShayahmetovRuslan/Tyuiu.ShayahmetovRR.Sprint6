namespace Tyuiu.ShayahmetovRR.Sprint6.Task2.V15
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
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.buttonDone_SRR = new System.Windows.Forms.Button();
			this.buttonInfo_SRR = new System.Windows.Forms.Button();
			this.groupBoxStartStopValue_SRR = new System.Windows.Forms.GroupBox();
			this.labelStopValue_SRR = new System.Windows.Forms.Label();
			this.labelStartValue_SRR = new System.Windows.Forms.Label();
			this.textBoxStopValue_SRR = new System.Windows.Forms.TextBox();
			this.textBoxStartValue_SRR = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.groupBoxOutput_SRR = new System.Windows.Forms.GroupBox();
			this.chartFunction_SSR = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.dataGridViewResult_SRR = new System.Windows.Forms.DataGridView();
			this.X = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.gridViewTextBoxVarX_SRR = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.labelResult_SRR = new System.Windows.Forms.Label();
			this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
			this.groupBoxStartStopValue_SRR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.groupBoxOutput_SRR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartFunction_SSR)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SRR)).BeginInit();
			this.groupBoxCondition_SRR.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonDone_SRR
			// 
			this.buttonDone_SRR.BackColor = System.Drawing.Color.Green;
			this.buttonDone_SRR.Location = new System.Drawing.Point(392, 314);
			this.buttonDone_SRR.Name = "buttonDone_SRR";
			this.buttonDone_SRR.Size = new System.Drawing.Size(91, 68);
			this.buttonDone_SRR.TabIndex = 1;
			this.buttonDone_SRR.Text = "Выполнить";
			this.buttonDone_SRR.UseVisualStyleBackColor = false;
			this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
			// 
			// buttonInfo_SRR
			// 
			this.buttonInfo_SRR.BackColor = System.Drawing.SystemColors.Highlight;
			this.buttonInfo_SRR.Location = new System.Drawing.Point(295, 314);
			this.buttonInfo_SRR.Name = "buttonInfo_SRR";
			this.buttonInfo_SRR.Size = new System.Drawing.Size(91, 68);
			this.buttonInfo_SRR.TabIndex = 1;
			this.buttonInfo_SRR.Text = "Справка";
			this.buttonInfo_SRR.UseVisualStyleBackColor = false;
			this.buttonInfo_SRR.Click += new System.EventHandler(this.buttonInfo_SRR_Click);
			// 
			// groupBoxStartStopValue_SRR
			// 
			this.groupBoxStartStopValue_SRR.Controls.Add(this.labelStopValue_SRR);
			this.groupBoxStartStopValue_SRR.Controls.Add(this.labelStartValue_SRR);
			this.groupBoxStartStopValue_SRR.Controls.Add(this.textBoxStopValue_SRR);
			this.groupBoxStartStopValue_SRR.Controls.Add(this.textBoxStartValue_SRR);
			this.groupBoxStartStopValue_SRR.Location = new System.Drawing.Point(35, 314);
			this.groupBoxStartStopValue_SRR.Name = "groupBoxStartStopValue_SRR";
			this.groupBoxStartStopValue_SRR.Size = new System.Drawing.Size(218, 68);
			this.groupBoxStartStopValue_SRR.TabIndex = 2;
			this.groupBoxStartStopValue_SRR.TabStop = false;
			this.groupBoxStartStopValue_SRR.Text = "Ввод данных";
			// 
			// labelStopValue_SRR
			// 
			this.labelStopValue_SRR.AutoSize = true;
			this.labelStopValue_SRR.Location = new System.Drawing.Point(112, 20);
			this.labelStopValue_SRR.Name = "labelStopValue_SRR";
			this.labelStopValue_SRR.Size = new System.Drawing.Size(66, 13);
			this.labelStopValue_SRR.TabIndex = 3;
			this.labelStopValue_SRR.Text = "Конец шага";
			// 
			// labelStartValue_SRR
			// 
			this.labelStartValue_SRR.AutoSize = true;
			this.labelStartValue_SRR.Location = new System.Drawing.Point(7, 20);
			this.labelStartValue_SRR.Name = "labelStartValue_SRR";
			this.labelStartValue_SRR.Size = new System.Drawing.Size(72, 13);
			this.labelStartValue_SRR.TabIndex = 2;
			this.labelStartValue_SRR.Text = "Начало шага";
			// 
			// textBoxStopValue_SRR
			// 
			this.textBoxStopValue_SRR.Location = new System.Drawing.Point(112, 42);
			this.textBoxStopValue_SRR.Multiline = true;
			this.textBoxStopValue_SRR.Name = "textBoxStopValue_SRR";
			this.textBoxStopValue_SRR.Size = new System.Drawing.Size(100, 20);
			this.textBoxStopValue_SRR.TabIndex = 0;
			// 
			// textBoxStartValue_SRR
			// 
			this.textBoxStartValue_SRR.Location = new System.Drawing.Point(6, 42);
			this.textBoxStartValue_SRR.Multiline = true;
			this.textBoxStartValue_SRR.Name = "textBoxStartValue_SRR";
			this.textBoxStartValue_SRR.Size = new System.Drawing.Size(100, 20);
			this.textBoxStartValue_SRR.TabIndex = 0;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::Tyuiu.ShayahmetovRR.Sprint6.Task2.V15.Properties.Resources.Screenshot_5;
			this.pictureBox1.Location = new System.Drawing.Point(7, 21);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(576, 190);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBox1.TabIndex = 3;
			this.pictureBox1.TabStop = false;
			// 
			// groupBoxOutput_SRR
			// 
			this.groupBoxOutput_SRR.Controls.Add(this.chartFunction_SSR);
			this.groupBoxOutput_SRR.Controls.Add(this.dataGridViewResult_SRR);
			this.groupBoxOutput_SRR.Controls.Add(this.labelResult_SRR);
			this.groupBoxOutput_SRR.Location = new System.Drawing.Point(594, 12);
			this.groupBoxOutput_SRR.Name = "groupBoxOutput_SRR";
			this.groupBoxOutput_SRR.Size = new System.Drawing.Size(443, 426);
			this.groupBoxOutput_SRR.TabIndex = 4;
			this.groupBoxOutput_SRR.TabStop = false;
			this.groupBoxOutput_SRR.Text = "Вывод данных";
			// 
			// chartFunction_SSR
			// 
			chartArea1.Name = "ChartArea1";
			this.chartFunction_SSR.ChartAreas.Add(chartArea1);
			legend1.Enabled = false;
			legend1.Name = "Legend1";
			this.chartFunction_SSR.Legends.Add(legend1);
			this.chartFunction_SSR.Location = new System.Drawing.Point(120, 32);
			this.chartFunction_SSR.Name = "chartFunction_SSR";
			series1.ChartArea = "ChartArea1";
			series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
			series1.Legend = "Legend1";
			series1.Name = "Series1";
			this.chartFunction_SSR.Series.Add(series1);
			this.chartFunction_SSR.Size = new System.Drawing.Size(300, 300);
			this.chartFunction_SSR.TabIndex = 3;
			this.chartFunction_SSR.Text = "chartFunction_SSR";
			// 
			// dataGridViewResult_SRR
			// 
			this.dataGridViewResult_SRR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewResult_SRR.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.X,
            this.gridViewTextBoxVarX_SRR});
			this.dataGridViewResult_SRR.Location = new System.Drawing.Point(10, 32);
			this.dataGridViewResult_SRR.Name = "dataGridViewResult_SRR";
			this.dataGridViewResult_SRR.RowHeadersVisible = false;
			this.dataGridViewResult_SRR.Size = new System.Drawing.Size(104, 388);
			this.dataGridViewResult_SRR.TabIndex = 2;
			// 
			// X
			// 
			this.X.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
			this.X.FillWeight = 50F;
			this.X.HeaderText = "X";
			this.X.MinimumWidth = 50;
			this.X.Name = "X";
			this.X.Width = 50;
			// 
			// gridViewTextBoxVarX_SRR
			// 
			this.gridViewTextBoxVarX_SRR.FillWeight = 50F;
			this.gridViewTextBoxVarX_SRR.HeaderText = "F(X)";
			this.gridViewTextBoxVarX_SRR.Name = "gridViewTextBoxVarX_SRR";
			this.gridViewTextBoxVarX_SRR.Width = 50;
			// 
			// labelResult_SRR
			// 
			this.labelResult_SRR.AutoSize = true;
			this.labelResult_SRR.Location = new System.Drawing.Point(7, 16);
			this.labelResult_SRR.Name = "labelResult_SRR";
			this.labelResult_SRR.Size = new System.Drawing.Size(59, 13);
			this.labelResult_SRR.TabIndex = 1;
			this.labelResult_SRR.Text = "Результат";
			// 
			// groupBoxCondition_SRR
			// 
			this.groupBoxCondition_SRR.Controls.Add(this.pictureBox1);
			this.groupBoxCondition_SRR.Location = new System.Drawing.Point(12, 12);
			this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
			this.groupBoxCondition_SRR.Size = new System.Drawing.Size(583, 216);
			this.groupBoxCondition_SRR.TabIndex = 5;
			this.groupBoxCondition_SRR.TabStop = false;
			this.groupBoxCondition_SRR.Text = "Условие";
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1060, 450);
			this.Controls.Add(this.groupBoxCondition_SRR);
			this.Controls.Add(this.groupBoxOutput_SRR);
			this.Controls.Add(this.groupBoxStartStopValue_SRR);
			this.Controls.Add(this.buttonInfo_SRR);
			this.Controls.Add(this.buttonDone_SRR);
			this.Name = "FormMain";
			this.Text = "FormMain";
			this.groupBoxStartStopValue_SRR.ResumeLayout(false);
			this.groupBoxStartStopValue_SRR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.groupBoxOutput_SRR.ResumeLayout(false);
			this.groupBoxOutput_SRR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.chartFunction_SSR)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewResult_SRR)).EndInit();
			this.groupBoxCondition_SRR.ResumeLayout(false);
			this.groupBoxCondition_SRR.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonDone_SRR;
		private System.Windows.Forms.Button buttonInfo_SRR;
		private System.Windows.Forms.GroupBox groupBoxStartStopValue_SRR;
		private System.Windows.Forms.Label labelStopValue_SRR;
		private System.Windows.Forms.Label labelStartValue_SRR;
		private System.Windows.Forms.TextBox textBoxStopValue_SRR;
		private System.Windows.Forms.TextBox textBoxStartValue_SRR;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.GroupBox groupBoxOutput_SRR;
		private System.Windows.Forms.Label labelResult_SRR;
		private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
		private System.Windows.Forms.DataGridView dataGridViewResult_SRR;
		private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_SSR;
		private System.Windows.Forms.DataGridViewTextBoxColumn X;
		private System.Windows.Forms.DataGridViewTextBoxColumn gridViewTextBoxVarX_SRR;
	}
}

