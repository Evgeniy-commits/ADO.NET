namespace Academy
{
	partial class MainForm
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
			this.statusStrip = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.buttonAddStudent = new System.Windows.Forms.Button();
			this.cbStudentsDirection = new System.Windows.Forms.ComboBox();
			this.cbStudentsGroup = new System.Windows.Forms.ComboBox();
			this.dgvStudents = new System.Windows.Forms.DataGridView();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.cbGroupsDirection = new System.Windows.Forms.ComboBox();
			this.dgvGroups = new System.Windows.Forms.DataGridView();
			this.tabPageDirections = new System.Windows.Forms.TabPage();
			this.dgvDirections = new System.Windows.Forms.DataGridView();
			this.tabPageDisciplines = new System.Windows.Forms.TabPage();
			this.dgvDisciplines = new System.Windows.Forms.DataGridView();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.buttonAddTeacher = new System.Windows.Forms.Button();
			this.dgvTeachers = new System.Windows.Forms.DataGridView();
			this.statusStrip.SuspendLayout();
			this.tabControl.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).BeginInit();
			this.tabPageGroups.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).BeginInit();
			this.tabPageDirections.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).BeginInit();
			this.tabPageDisciplines.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).BeginInit();
			this.tabPageTeachers.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
			this.SuspendLayout();
			// 
			// statusStrip
			// 
			this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
			this.statusStrip.Location = new System.Drawing.Point(0, 383);
			this.statusStrip.Name = "statusStrip";
			this.statusStrip.Size = new System.Drawing.Size(698, 22);
			this.statusStrip.TabIndex = 0;
			this.statusStrip.Text = "statusStrip1";
			// 
			// toolStripStatusLabel
			// 
			this.toolStripStatusLabel.Name = "toolStripStatusLabel";
			this.toolStripStatusLabel.Size = new System.Drawing.Size(112, 17);
			this.toolStripStatusLabel.Text = "toolStripStatusLabel";
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageStudents);
			this.tabControl.Controls.Add(this.tabPageGroups);
			this.tabControl.Controls.Add(this.tabPageDirections);
			this.tabControl.Controls.Add(this.tabPageDisciplines);
			this.tabControl.Controls.Add(this.tabPageTeachers);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Multiline = true;
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(698, 383);
			this.tabControl.TabIndex = 1;
			this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.buttonAddStudent);
			this.tabPageStudents.Controls.Add(this.cbStudentsDirection);
			this.tabPageStudents.Controls.Add(this.cbStudentsGroup);
			this.tabPageStudents.Controls.Add(this.dgvStudents);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(690, 357);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Students";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// buttonAddStudent
			// 
			this.buttonAddStudent.Location = new System.Drawing.Point(552, 7);
			this.buttonAddStudent.Name = "buttonAddStudent";
			this.buttonAddStudent.Size = new System.Drawing.Size(75, 23);
			this.buttonAddStudent.TabIndex = 4;
			this.buttonAddStudent.Text = "Добавить";
			this.buttonAddStudent.UseVisualStyleBackColor = true;
			this.buttonAddStudent.Click += new System.EventHandler(this.buttonAddStudent_Click);
			// 
			// cbStudentsDirection
			// 
			this.cbStudentsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStudentsDirection.FormattingEnabled = true;
			this.cbStudentsDirection.Location = new System.Drawing.Point(185, 6);
			this.cbStudentsDirection.Name = "cbStudentsDirection";
			this.cbStudentsDirection.Size = new System.Drawing.Size(330, 21);
			this.cbStudentsDirection.TabIndex = 3;
			this.cbStudentsDirection.SelectedIndexChanged += new System.EventHandler(this.cbStudentsDirection_SelectedIndexChanged);
			// 
			// cbStudentsGroup
			// 
			this.cbStudentsGroup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbStudentsGroup.FormattingEnabled = true;
			this.cbStudentsGroup.Location = new System.Drawing.Point(8, 4);
			this.cbStudentsGroup.Name = "cbStudentsGroup";
			this.cbStudentsGroup.Size = new System.Drawing.Size(142, 21);
			this.cbStudentsGroup.TabIndex = 2;
			// 
			// dgvStudents
			// 
			this.dgvStudents.AllowUserToAddRows = false;
			this.dgvStudents.AllowUserToDeleteRows = false;
			this.dgvStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvStudents.Location = new System.Drawing.Point(8, 45);
			this.dgvStudents.MultiSelect = false;
			this.dgvStudents.Name = "dgvStudents";
			this.dgvStudents.ReadOnly = true;
			this.dgvStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvStudents.Size = new System.Drawing.Size(674, 300);
			this.dgvStudents.TabIndex = 1;
			this.dgvStudents.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvStudents_CellMouseDoubleClick);
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Controls.Add(this.cbGroupsDirection);
			this.tabPageGroups.Controls.Add(this.dgvGroups);
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(690, 357);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Groups";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// cbGroupsDirection
			// 
			this.cbGroupsDirection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbGroupsDirection.FormattingEnabled = true;
			this.cbGroupsDirection.Location = new System.Drawing.Point(165, 6);
			this.cbGroupsDirection.Name = "cbGroupsDirection";
			this.cbGroupsDirection.Size = new System.Drawing.Size(299, 21);
			this.cbGroupsDirection.TabIndex = 2;
			this.cbGroupsDirection.SelectedIndexChanged += new System.EventHandler(this.cbGroupsDirection_SelectedIndexChanged);
			// 
			// dgvGroups
			// 
			this.dgvGroups.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvGroups.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvGroups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvGroups.Location = new System.Drawing.Point(8, 33);
			this.dgvGroups.Name = "dgvGroups";
			this.dgvGroups.Size = new System.Drawing.Size(674, 312);
			this.dgvGroups.TabIndex = 1;
			// 
			// tabPageDirections
			// 
			this.tabPageDirections.Controls.Add(this.dgvDirections);
			this.tabPageDirections.Location = new System.Drawing.Point(4, 22);
			this.tabPageDirections.Name = "tabPageDirections";
			this.tabPageDirections.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDirections.Size = new System.Drawing.Size(690, 357);
			this.tabPageDirections.TabIndex = 2;
			this.tabPageDirections.Text = "Directions";
			this.tabPageDirections.UseVisualStyleBackColor = true;
			// 
			// dgvDirections
			// 
			this.dgvDirections.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDirections.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvDirections.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDirections.Location = new System.Drawing.Point(9, 23);
			this.dgvDirections.Name = "dgvDirections";
			this.dgvDirections.Size = new System.Drawing.Size(675, 334);
			this.dgvDirections.TabIndex = 0;
			// 
			// tabPageDisciplines
			// 
			this.tabPageDisciplines.Controls.Add(this.dgvDisciplines);
			this.tabPageDisciplines.Location = new System.Drawing.Point(4, 22);
			this.tabPageDisciplines.Name = "tabPageDisciplines";
			this.tabPageDisciplines.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageDisciplines.Size = new System.Drawing.Size(690, 357);
			this.tabPageDisciplines.TabIndex = 3;
			this.tabPageDisciplines.Text = "Disciplines";
			this.tabPageDisciplines.UseVisualStyleBackColor = true;
			// 
			// dgvDisciplines
			// 
			this.dgvDisciplines.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvDisciplines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvDisciplines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisciplines.Location = new System.Drawing.Point(8, 11);
			this.dgvDisciplines.Name = "dgvDisciplines";
			this.dgvDisciplines.Size = new System.Drawing.Size(675, 334);
			this.dgvDisciplines.TabIndex = 1;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Controls.Add(this.buttonAddTeacher);
			this.tabPageTeachers.Controls.Add(this.dgvTeachers);
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(690, 357);
			this.tabPageTeachers.TabIndex = 4;
			this.tabPageTeachers.Text = "Teachers";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// buttonAddTeacher
			// 
			this.buttonAddTeacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonAddTeacher.Location = new System.Drawing.Point(553, 4);
			this.buttonAddTeacher.Name = "buttonAddTeacher";
			this.buttonAddTeacher.Size = new System.Drawing.Size(129, 35);
			this.buttonAddTeacher.TabIndex = 2;
			this.buttonAddTeacher.Text = "Добавить";
			this.buttonAddTeacher.UseVisualStyleBackColor = true;
			this.buttonAddTeacher.Click += new System.EventHandler(this.buttonAddTeacher_Click);
			// 
			// dgvTeachers
			// 
			this.dgvTeachers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
			this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvTeachers.Location = new System.Drawing.Point(8, 45);
			this.dgvTeachers.Name = "dgvTeachers";
			this.dgvTeachers.Size = new System.Drawing.Size(675, 300);
			this.dgvTeachers.TabIndex = 1;
			this.dgvTeachers.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvTeachers_CellMouseDoubleClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(698, 405);
			this.Controls.Add(this.tabControl);
			this.Controls.Add(this.statusStrip);
			this.Name = "MainForm";
			this.Text = "Academy PV_521";
			this.statusStrip.ResumeLayout(false);
			this.statusStrip.PerformLayout();
			this.tabControl.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvStudents)).EndInit();
			this.tabPageGroups.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvGroups)).EndInit();
			this.tabPageDirections.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDirections)).EndInit();
			this.tabPageDisciplines.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvDisciplines)).EndInit();
			this.tabPageTeachers.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.StatusStrip statusStrip;
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageDirections;
		private System.Windows.Forms.DataGridView dgvDirections;
		private System.Windows.Forms.TabPage tabPageDisciplines;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
		private System.Windows.Forms.DataGridView dgvStudents;
		private System.Windows.Forms.DataGridView dgvGroups;
		private System.Windows.Forms.DataGridView dgvDisciplines;
		private System.Windows.Forms.DataGridView dgvTeachers;
		private System.Windows.Forms.ComboBox cbGroupsDirection;
		private System.Windows.Forms.ComboBox cbStudentsDirection;
		private System.Windows.Forms.ComboBox cbStudentsGroup;
		private System.Windows.Forms.Button buttonAddStudent;
		private System.Windows.Forms.Button buttonAddTeacher;
	}
}

