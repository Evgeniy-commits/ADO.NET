using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace Academy
{
	public partial class HumanForm : Form
	{
		internal Models.Human human;
		protected HumanForm()
		{
			InitializeComponent();
		}
		protected void Extract()
		{
			if(human != null)
			{
				if(human.id != 0) labelID.Text = $"ID:{human.id}";
				tbLastName.Text = human.last_name;
				tbFirstName.Text = human.first_name;
				tbMiddleName.Text = human.middle_name;
				dtpBirthDate.Value = Convert.ToDateTime(human.birth_date);
				tbEmail.Text = human.email;
				tbPhone.Text = human.phone;
			}
		}
		
		protected virtual void buttonOk_Click(object sender, EventArgs e)
		{
			human = new Models.Human
				(
					labelID.Text == "" ? 0 : Convert.ToInt32(labelID.Text.Split(':').Last()),
					tbLastName.Text,
					tbFirstName.Text,
					tbMiddleName.Text,
					dtpBirthDate.Value.ToString("yyyy-MM-dd"),
					tbEmail.Text,
					tbPhone.Text,
					pbPhoto.Image
				);
		}
	}
}
