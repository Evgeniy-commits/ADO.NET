using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class StudentForm : HumanForm
	{
		internal Models.Student student;
		public StudentForm()
		{
			InitializeComponent();

			DataTable groups = DataBase.Connector.Select("SELECT * FROM Groups");
			cbGroup.DataSource = groups;
			cbGroup.DisplayMember = "group_name";
			cbGroup.ValueMember = "group_id";
		}
		public StudentForm(int id) : this()
		{
			DataTable data = DataBase.Connector.Select("*","Students",$"stud_id = {id}");
			student = new Models.Student(data.Rows[0].ItemArray);
			human = student;
			Extract();
			cbGroup.SelectedValue = student.group;
			pbPhoto.Image = DataBase.Connector.DownloadPhoto("Students", "photo", student.id);
		}
		protected override void buttonOk_Click(object sender, EventArgs e)
		{
			base.buttonOk_Click(sender, e);
			student = new Models.Student
				(
					human,
					Convert.ToInt32(cbGroup.SelectedValue)
				);
			if ( student.id == 0 ) student.id = Convert.ToInt32(DataBase.Connector.Scalar
				(
				$"INSERT Students({student.GetNames()}) VALUES ({student.GetValues()});SELECT SCOPE_IDENTITY()")
				);
			else 
				DataBase.Connector.Update($"UPDATE Students SET {student.GetUpdateString()} WHERE stud_id={student.id}");
			if (student.photo != null)
				DataBase.Connector.UploadPhoto(student.SerializePhoto(), student.id, "photo", "Students");
			
			//DataBase.Connector.Insert
			//	(
			//		"Students",
			//		"last_name,first_name,middle_name,birth_date,email,phone,[group]",
			//		$"{tbLastName.Text},{tbFirstName.Text},{tbMiddleName.Text},{dtpBirthDate.Value.ToString("yyyy-MM-dd")},{tbEmail.Text},{tbPhone.Text},{cbGroup.SelectedValue}"
			//	);
		}
	}
}
