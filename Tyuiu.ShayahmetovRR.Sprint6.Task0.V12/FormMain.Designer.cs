namespace Tyuiu.ShayahmetovRR.Sprint6.Task0.V12
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
			this.buttonDone_SRR = new System.Windows.Forms.Button();
			this.groupBoxInputData_SRR = new System.Windows.Forms.GroupBox();
			this.labelVarX_SRR = new System.Windows.Forms.Label();
			this.textBoxVarX_SRR = new System.Windows.Forms.TextBox();
			this.groupBoxResult_SRR = new System.Windows.Forms.GroupBox();
			this.textBoxResult_SRR = new System.Windows.Forms.TextBox();
			this.pictureBoxCondition_SRR = new System.Windows.Forms.PictureBox();
			this.groupBoxCondition_SRR = new System.Windows.Forms.GroupBox();
			this.labelCondition_SRR = new System.Windows.Forms.Label();
			this.buttonStudentInfo_SRR = new System.Windows.Forms.Button();
			this.groupBoxInputData_SRR.SuspendLayout();
			this.groupBoxResult_SRR.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_SRR)).BeginInit();
			this.groupBoxCondition_SRR.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonDone_SRR
			// 
			this.buttonDone_SRR.Location = new System.Drawing.Point(638, 307);
			this.buttonDone_SRR.Name = "buttonDone_SRR";
			this.buttonDone_SRR.Size = new System.Drawing.Size(100, 41);
			this.buttonDone_SRR.TabIndex = 0;
			this.buttonDone_SRR.Text = "Выполнить";
			this.buttonDone_SRR.UseVisualStyleBackColor = true;
			this.buttonDone_SRR.Click += new System.EventHandler(this.buttonDone_SRR_Click);
			// 
			// groupBoxInputData_SRR
			// 
			this.groupBoxInputData_SRR.Controls.Add(this.labelVarX_SRR);
			this.groupBoxInputData_SRR.Controls.Add(this.textBoxVarX_SRR);
			this.groupBoxInputData_SRR.Location = new System.Drawing.Point(436, 216);
			this.groupBoxInputData_SRR.Name = "groupBoxInputData_SRR";
			this.groupBoxInputData_SRR.Size = new System.Drawing.Size(147, 85);
			this.groupBoxInputData_SRR.TabIndex = 1;
			this.groupBoxInputData_SRR.TabStop = false;
			this.groupBoxInputData_SRR.Text = "Ввод данных";
			this.groupBoxInputData_SRR.Enter += new System.EventHandler(this.groupBoxInputData_SRR_Enter);
			// 
			// labelVarX_SRR
			// 
			this.labelVarX_SRR.AutoSize = true;
			this.labelVarX_SRR.Location = new System.Drawing.Point(24, 22);
			this.labelVarX_SRR.Name = "labelVarX_SRR";
			this.labelVarX_SRR.Size = new System.Drawing.Size(84, 13);
			this.labelVarX_SRR.TabIndex = 1;
			this.labelVarX_SRR.Text = "Переменная X:";
			// 
			// textBoxVarX_SRR
			// 
			this.textBoxVarX_SRR.Location = new System.Drawing.Point(24, 41);
			this.textBoxVarX_SRR.Name = "textBoxVarX_SRR";
			this.textBoxVarX_SRR.Size = new System.Drawing.Size(100, 20);
			this.textBoxVarX_SRR.TabIndex = 0;
			this.textBoxVarX_SRR.TextChanged += new System.EventHandler(this.textBoxVarX_SRR_TextChanged);
			// 
			// groupBoxResult_SRR
			// 
			this.groupBoxResult_SRR.Controls.Add(this.textBoxResult_SRR);
			this.groupBoxResult_SRR.Location = new System.Drawing.Point(589, 216);
			this.groupBoxResult_SRR.Name = "groupBoxResult_SRR";
			this.groupBoxResult_SRR.Size = new System.Drawing.Size(147, 85);
			this.groupBoxResult_SRR.TabIndex = 2;
			this.groupBoxResult_SRR.TabStop = false;
			this.groupBoxResult_SRR.Text = "Результат";
			// 
			// textBoxResult_SRR
			// 
			this.textBoxResult_SRR.Location = new System.Drawing.Point(24, 41);
			this.textBoxResult_SRR.Name = "textBoxResult_SRR";
			this.textBoxResult_SRR.Size = new System.Drawing.Size(100, 20);
			this.textBoxResult_SRR.TabIndex = 0;
			// 
			// pictureBoxCondition_SRR
			// 
			this.pictureBoxCondition_SRR.Image = global::Tyuiu.ShayahmetovRR.Sprint6.Task0.V12.Properties.Resources.Task0;
			this.pictureBoxCondition_SRR.Location = new System.Drawing.Point(378, 19);
			this.pictureBoxCondition_SRR.Name = "pictureBoxCondition_SRR";
			this.pictureBoxCondition_SRR.Size = new System.Drawing.Size(251, 111);
			this.pictureBoxCondition_SRR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
			this.pictureBoxCondition_SRR.TabIndex = 3;
			this.pictureBoxCondition_SRR.TabStop = false;
			// 
			// groupBoxCondition_SRR
			// 
			this.groupBoxCondition_SRR.Controls.Add(this.labelCondition_SRR);
			this.groupBoxCondition_SRR.Controls.Add(this.pictureBoxCondition_SRR);
			this.groupBoxCondition_SRR.Location = new System.Drawing.Point(58, 32);
			this.groupBoxCondition_SRR.Name = "groupBoxCondition_SRR";
			this.groupBoxCondition_SRR.Size = new System.Drawing.Size(678, 158);
			this.groupBoxCondition_SRR.TabIndex = 4;
			this.groupBoxCondition_SRR.TabStop = false;
			this.groupBoxCondition_SRR.Text = "Условие";
			// 
			// labelCondition_SRR
			// 
			this.labelCondition_SRR.AutoSize = true;
			this.labelCondition_SRR.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelCondition_SRR.Location = new System.Drawing.Point(6, 19);
			this.labelCondition_SRR.Name = "labelCondition_SRR";
			this.labelCondition_SRR.Size = new System.Drawing.Size(341, 48);
			this.labelCondition_SRR.TabIndex = 4;
			this.labelCondition_SRR.Text = "Дано выражение вычислить его значение при x = 3.\r\nРезультат вывести в TextBox.\r\nО" +
    "круглить до трёх знаков после запятой.\r\n";
			// 
			// buttonStudentInfo_SRR
			// 
			this.buttonStudentInfo_SRR.Location = new System.Drawing.Point(589, 307);
			this.buttonStudentInfo_SRR.Name = "buttonStudentInfo_SRR";
			this.buttonStudentInfo_SRR.Size = new System.Drawing.Size(43, 41);
			this.buttonStudentInfo_SRR.TabIndex = 5;
			this.buttonStudentInfo_SRR.Text = "?";
			this.buttonStudentInfo_SRR.UseVisualStyleBackColor = true;
			this.buttonStudentInfo_SRR.Click += new System.EventHandler(this.buttonStudentInfo_SRR_Click);
			// 
			// FormMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.buttonStudentInfo_SRR);
			this.Controls.Add(this.groupBoxCondition_SRR);
			this.Controls.Add(this.groupBoxResult_SRR);
			this.Controls.Add(this.groupBoxInputData_SRR);
			this.Controls.Add(this.buttonDone_SRR);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "FormMain";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "FormMain";
			this.groupBoxInputData_SRR.ResumeLayout(false);
			this.groupBoxInputData_SRR.PerformLayout();
			this.groupBoxResult_SRR.ResumeLayout(false);
			this.groupBoxResult_SRR.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxCondition_SRR)).EndInit();
			this.groupBoxCondition_SRR.ResumeLayout(false);
			this.groupBoxCondition_SRR.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button buttonDone_SRR;
		private System.Windows.Forms.GroupBox groupBoxInputData_SRR;
		private System.Windows.Forms.TextBox textBoxVarX_SRR;
		private System.Windows.Forms.Label labelVarX_SRR;
		private System.Windows.Forms.GroupBox groupBoxResult_SRR;
		private System.Windows.Forms.TextBox textBoxResult_SRR;
		private System.Windows.Forms.PictureBox pictureBoxCondition_SRR;
		private System.Windows.Forms.GroupBox groupBoxCondition_SRR;
		private System.Windows.Forms.Label labelCondition_SRR;
		private System.Windows.Forms.Button buttonStudentInfo_SRR;
	}
}

