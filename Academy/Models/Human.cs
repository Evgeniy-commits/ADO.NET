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
		string last_name;
		string first_name;
		string middle_name;
		string birth_date;
		string email;
		string phone;
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
