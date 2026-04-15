using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	internal class Student : Human
	{
		int group;
		public Student
			(
				string last_name, string first_name, string middle_name, string birth_date,
				string email, string phone, Image photo, int group
			) : base(last_name, first_name, middle_name, birth_date, email, phone, photo)
		{
			this.group = group;
		}
		public Student(Human human, int group) : base(human)
		{
			this.group= group;
		}

		public override string GetNames()
		{
			return base.GetNames() + ",[group]";
		}
		public override string GetValues()
		{
			return $"{base.GetValues()},{group}";
		}
	}
}
