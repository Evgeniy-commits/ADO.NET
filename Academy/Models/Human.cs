using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.IO;

namespace Academy.Models
{
	internal class Human
	{
		internal int id;
		internal string last_name;
		internal string first_name;
		internal string middle_name;
		internal string birth_date;
		internal string email;
		internal string phone;
		internal Image photo;

		public Human(int id, string last_name, string first_name, string middle_name, string birth_date, string email, string phone, Image photo)
		{
			this.id = id;
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
			this.id = other.id;
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
			this.id = Convert.ToInt32(values[0]);
			this.last_name = values[1].ToString();
			this.first_name = values[2].ToString();
			this.middle_name = values[3].ToString();
			this.birth_date = values[4].ToString();
			this.email = values[5].ToString();
			this.phone = values[6].ToString();
		}
		public byte[] SerializePhoto()
		{
			if (photo == null) return null;
			MemoryStream ms = new MemoryStream();
			photo.Save(ms, photo.RawFormat);
			return ms.ToArray();
		}
		public virtual string GetNames()
		{ 
			return $"last_name,first_name,middle_name,birth_date,email,phone"; 
		}
		public virtual string GetValues()
		{ 
			return $"N'{last_name}',N'{first_name}',N'{middle_name}',N'{birth_date}',N'{email}',N'{phone}'"; 
		} 
		public virtual string GetCondition()
		{
			return $" last_name=N'{last_name}' AND first_name=N'{first_name}' AND middle_name=N'{middle_name}'" +
				   $" AND birth_date=N'{birth_date}' AND email=N'{email}' AND phone=N'{phone}'";
		}
		
	}
}
