using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Academy.Models
{
	internal class Teacher : Human
	{
		internal string work_since;
		internal decimal rate;

		public Teacher(Human other) : base(other)
		{
		}

		public Teacher
			(
			int id,
			string last_name, string first_name, string middle_name,
			string birth_date, string email, string phone, Image photo,
			string work_since, decimal rate
			) : base(id, last_name, first_name, middle_name, birth_date, email, phone, photo)
		{
			this.work_since = work_since;
			this.rate = rate;
		}
		public Teacher(Human human, string work_since, decimal rate) : base(human)
		{
			this.work_since = work_since;
			this.rate = rate;
		}
		public Teacher(object[] values) : base(values)
		{
			this.work_since = values[8].ToString();
			this.rate = Convert.ToDecimal(values[9]);
		}
		public override string GetNames()
		{
			return base.GetNames() + ",work_since,rate";
		}
		public override string GetValues()
		{
			return base.GetValues() + $",N'{work_since}',{rate}";
		}
		public override string GetCondition()
		{
			return base.GetCondition() + $" AND work_since=N'{work_since}' AND rate={rate}";
		}
		//public string GetUpdateString()
		//{
		//	return GetCondition().Replace(" AND ", ",");
		//}
	}
}
