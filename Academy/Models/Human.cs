using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	internal class Human
	{
		internal string last_name;
		internal string first_name;
		internal string middle_name;
		internal string birth_date;
		internal string email;
		internal string phone;
		Image photo;

		public Human(string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo)
		{
			this.last_name = last_name;
			this.first_name = first_name;
			this.middle_name = middle_name;
			this.birth_date = birth_date;
			this.email = email;
			this.phone = phone;
			this.photo = photo;
		}
		public Human(Human other)
		{ 
			this.last_name = other.last_name;
			this.first_name = other.first_name;
			this.middle_name = other.middle_name;
			this.birth_date = other.birth_date;
			this.email = other.email;
			this.phone = other.phone;
			this.photo = other.photo;
		}
		public Human(object[] values)
		{
			this.last_name = values[1].ToString();
			this.first_name = values[2].ToString();
			this.middle_name = values[3].ToString();
			this.birth_date = values[4].ToString();
			this.email = values[5].ToString();
			this.phone = values[6].ToString();
		}
		public virtual string GetNames()
		{ 
			return $"last_name,first_name,middle_name,birth_date,email,phone"; 
		}
		public virtual string GetValues()
		{ 
			return $"N'{last_name}',N'{first_name}',N'{middle_name}',N'{birth_date}',N'{email}',N'{phone}'"; 
		} 
		
	}
}
