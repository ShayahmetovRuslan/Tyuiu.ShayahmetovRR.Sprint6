namespace Tyuiu.ShayahmetovRR.Sprint6.Task6.V16
{
	partial class FormAbout2
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout2));
			this.labelAbout_SRR = new System.Windows.Forms.Label();
			this.pictureBoxAvatar_SRR = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SRR)).BeginInit();
			this.SuspendLayout();
			// 
			// labelAbout_SRR
			// 
			this.labelAbout_SRR.AutoSize = true;
			this.labelAbout_SRR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.labelAbout_SRR.Location = new System.Drawing.Point(246, 9);
			this.labelAbout_SRR.Name = "labelAbout_SRR";
			this.labelAbout_SRR.Size = new System.Drawing.Size(298, 119);
			this.labelAbout_SRR.TabIndex = 0;
			this.labelAbout_SRR.Text = "Разработчик: Шаяхметов Р. Р.\r\nГруппа: АСОиУб-23-1.\r\n\r\nПрограмма разработки в рамк" +
    "ах обучения языка C#.\r\n\r\nТИУ (с) 2023\r\nВШЦТ (с) 2023\r\n\r\nВнутреннее имя: Tyuiu.Sh" +
    "ayahmetovRR.Sprint6.Task6.V16";
			// 
			// pictureBoxAvatar_SRR
			// 
			this.pictureBoxAvatar_SRR.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxAvatar_SRR.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAvatar_SRR.Image")));
			this.pictureBoxAvatar_SRR.Location = new System.Drawing.Point(12, 9);
			this.pictureBoxAvatar_SRR.Name = "pictureBoxAvatar_SRR";
			this.pictureBoxAvatar_SRR.Size = new System.Drawing.Size(228, 223);
			this.pictureBoxAvatar_SRR.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
			this.pictureBoxAvatar_SRR.TabIndex = 1;
			this.pictureBoxAvatar_SRR.TabStop = false;
			// 
			// FormAbout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(645, 250);
			this.Controls.Add(this.pictureBoxAvatar_SRR);
			this.Controls.Add(this.labelAbout_SRR);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormAbout";
			this.Text = "FormAbout";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_SRR)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelAbout_SRR;
		private System.Windows.Forms.PictureBox pictureBoxAvatar_SRR;
	}
}