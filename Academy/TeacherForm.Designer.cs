namespace Academy
{
	partial class TeacherForm
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
			this.dtpWorkSince = new System.Windows.Forms.DateTimePicker();
			this.tbRate = new System.Windows.Forms.TextBox();
			this.labelWorkSince = new System.Windows.Forms.Label();
			this.labelRate = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// dtpWorkSince
			// 
			this.dtpWorkSince.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpWorkSince.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpWorkSince.Location = new System.Drawing.Point(223, 241);
			this.dtpWorkSince.Name = "dtpWorkSince";
			this.dtpWorkSince.Size = new System.Drawing.Size(374, 31);
			this.dtpWorkSince.TabIndex = 17;
			// 
			// tbRate
			// 
			this.tbRate.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
			this.tbRate.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
			this.tbRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbRate.Location = new System.Drawing.Point(223, 280);
			this.tbRate.Name = "tbRate";
			this.tbRate.Size = new System.Drawing.Size(151, 31);
			this.tbRate.TabIndex = 18;
			// 
			// labelWorkSince
			// 
			this.labelWorkSince.AutoSize = true;
			this.labelWorkSince.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelWorkSince.Location = new System.Drawing.Point(56, 244);
			this.labelWorkSince.Name = "labelWorkSince";
			this.labelWorkSince.Size = new System.Drawing.Size(129, 25);
			this.labelWorkSince.TabIndex = 19;
			this.labelWorkSince.Text = "Работает с:";
			// 
			// labelRate
			// 
			this.labelRate.AutoSize = true;
			this.labelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelRate.Location = new System.Drawing.Point(14, 283);
			this.labelRate.Name = "labelRate";
			this.labelRate.Size = new System.Drawing.Size(171, 25);
			this.labelRate.TabIndex = 20;
			this.labelRate.Text = "Ставка за пару:";
			// 
			// TeacherForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(837, 351);
			this.Controls.Add(this.labelRate);
			this.Controls.Add(this.labelWorkSince);
			this.Controls.Add(this.tbRate);
			this.Controls.Add(this.dtpWorkSince);
			this.Name = "TeacherForm";
			this.Text = "TeacherForm";
			this.Controls.SetChildIndex(this.tbLastName, 0);
			this.Controls.SetChildIndex(this.tbFirstName, 0);
			this.Controls.SetChildIndex(this.tbMiddleName, 0);
			this.Controls.SetChildIndex(this.dtpBirthDate, 0);
			this.Controls.SetChildIndex(this.pbPhoto, 0);
			this.Controls.SetChildIndex(this.tbEmail, 0);
			this.Controls.SetChildIndex(this.tbPhone, 0);
			this.Controls.SetChildIndex(this.dtpWorkSince, 0);
			this.Controls.SetChildIndex(this.tbRate, 0);
			this.Controls.SetChildIndex(this.labelWorkSince, 0);
			this.Controls.SetChildIndex(this.labelRate, 0);
			((System.ComponentModel.ISupportInitialize)(this.pbPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DateTimePicker dtpWorkSince;
		private System.Windows.Forms.TextBox tbRate;
		private System.Windows.Forms.Label labelWorkSince;
		private System.Windows.Forms.Label labelRate;
	}
}