namespace Tyuiu.ShayahmetovRR.Sprint6.Task3.V26
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
			this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
			this.dataGridViewCondition_SSR = new System.Windows.Forms.DataGridView();
			this.labelCondition_SRR = new System.Windows.Forms.Label();
			this.groupBoxOutput_SSR = new System.Windows.Forms.GroupBox();
			this.labelResult_SSR = new System.Windows.Forms.Label();
			this.dataGridViewOutput_SSR = new System.Windows.Forms.DataGridView();
			this.buttonDone_SSR = new System.Windows.Forms.Button();
			this.buttonAboutStudent_SSR = new System.Windows.Forms.Button();
			this.groupBoxCondition_SRR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondition_SSR)).BeginInit();
			this.groupBoxOutput_SSR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SSR)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBoxCondition_SRR
			// 
			this.groupBoxCondition_SRR.Controls.Add(this.dataGridViewCondition_SSR);
			this.groupBoxCondition_SRR.Controls.Add(this.labelCondition_SRR);
			this.groupBoxCondition_SRR.Location = new System.Drawing.Point(12, 12);
			this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
			this.groupBoxCondition_SRR.Size = new System.Drawing.Size(283, 426);
			this.groupBoxCondition_SRR.TabIndex = 0;
			this.groupBoxCondition_SRR.TabStop = false;
			this.groupBoxCondition_SRR.Text = "Условие";
			// 
			// dataGridViewCondition_SSR
			// 
			this.dataGridViewCondition_SSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewCondition_SSR.ColumnHeadersVisible = false;
			this.dataGridViewCondition_SSR.Location = new System.Drawing.Point(6, 149);
			this.dataGridViewCondition_SSR.Name = "dataGridViewCondition_SSR";
			this.dataGridViewCondition_SSR.RowHeadersVisible = false;
			this.dataGridViewCondition_SSR.Size = new System.Drawing.Size(271, 271);
			this.dataGridViewCondition_SSR.TabIndex = 0;
			// 
			// labelCondition_SRR
			// 
			this.labelCondition_SRR.AutoSize = true;
			this.labelCondition_SRR.Location = new System.Drawing.Point(6, 16);
			this.labelCondition_SRR.Name = "labelCondition_SRR";
			this.labelCondition_SRR.Size = new System.Drawing.Size(185, 130);
			this.labelCondition_SRR.TabIndex = 0;
			this.labelCondition_SRR.Text = resources.GetString("labelCondition_SRR.Text");
			// 
			// groupBoxOutput_SSR
			// 
			this.groupBoxOutput_SSR.Controls.Add(this.dataGridViewOutput_SSR);
			this.groupBoxOutput_SSR.Controls.Add(this.labelResult_SSR);
			this.groupBoxOutput_SSR.Location = new System.Drawing.Point(301, 12);
			this.groupBoxOutput_SSR.Name = "groupBoxOutput_SSR";
			this.groupBoxOutput_SSR.Size = new System.Drawing.Size(262, 426);
			this.groupBoxOutput_SSR.TabIndex = 1;
			this.groupBoxOutput_SSR.TabStop = false;
			this.groupBoxOutput_SSR.Text = "Вывод данных";
			// 
			// labelResult_SSR
			// 
			this.labelResult_SSR.AutoSize = true;
			this.labelResult_SSR.Location = new System.Drawing.Point(6, 23);
			this.labelResult_SSR.Name = "labelResult_SSR";
			this.labelResult_SSR.Size = new System.Drawing.Size(62, 13);
			this.labelResult_SSR.TabIndex = 1;
			this.labelResult_SSR.Text = "Результат:";
			// 
			// dataGridViewOutput_SSR
			// 
			this.dataGridViewOutput_SSR.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewOutput_SSR.ColumnHeadersVisible = false;
			this.dataGridViewOutput_SSR.Location = new System.Drawing.Point(9, 40);
			this.dataGridViewOutput_SSR.Name = "dataGridViewOutput_SSR";
			this.dataGridViewOutput_SSR.RowHeadersVisible = false;
			this.dataGridViewOutput_SSR.Size = new System.Drawing.Size(240, 380);
			this.dataGridViewOutput_SSR.TabIndex = 2;
			// 
			// buttonDone_SSR
			// 
			this.buttonDone_SSR.Location = new System.Drawing.Point(569, 385);
			this.buttonDone_SSR.Name = "buttonDone_SSR";
			this.buttonDone_SSR.Size = new System.Drawing.Size(120, 47);
			this.buttonDone_SSR.TabIndex = 2;
			this.buttonDone_SSR.Text = "Выполнить";
			this.buttonDone_SSR.UseVisualStyleBackColor = true;
			this.buttonDone_SSR.Click += new System.EventHandler(this.buttonDone_SSR_Click);
			// 
			// buttonAboutStudent_SSR
			// 
			this.buttonAboutStudent_SSR.Location = new System.Drawing.Point(696, 385);
			this.buttonAboutStudent_SSR.Name = "buttonAboutStudent_SSR";
			this.buttonAboutStudent_SSR.Size = new System.Drawing.Size(49, 47);
			this.buttonAboutStudent_SSR.TabIndex = 3;
			this.buttonAboutStudent_SSR.Text = "?";
			this.buttonAboutStudent_SSR.UseVisualStyleBackColor = true;
			this.buttonAboutStudent_SSR.Click += new System.EventHandler(this.buttonAboutStudent_SSR_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonAboutStudent_SSR);
			this.Controls.Add(this.buttonDone_SSR);
			this.Controls.Add(this.groupBoxOutput_SSR);
			this.Controls.Add(this.groupBoxCondition_SRR);
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.Text = "Спринт 6 | Таск 3 | Вариант 26 | Шаяхметов Р. Р. ";
			this.Load += new System.EventHandler(this.FormMain_Load);
			this.groupBoxCondition_SRR.ResumeLayout(false);
			this.groupBoxCondition_SRR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewCondition_SSR)).EndInit();
			this.groupBoxOutput_SSR.ResumeLayout(false);
			this.groupBoxOutput_SSR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewOutput_SSR)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
		private System.Windows.Forms.Label labelCondition_SRR;
		private System.Windows.Forms.GroupBox groupBoxOutput_SSR;
		private System.Windows.Forms.DataGridView dataGridViewCondition_SSR;
		private System.Windows.Forms.Label labelResult_SSR;
		private System.Windows.Forms.DataGridView dataGridViewOutput_SSR;
		private System.Windows.Forms.Button buttonDone_SSR;
		private System.Windows.Forms.Button buttonAboutStudent_SSR;
	}
}

