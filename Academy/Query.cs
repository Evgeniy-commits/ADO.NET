using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Academy
{
	internal class Query
	{
		public string Fields { get; set; }
		public string Tables { get; set; }
		public string Condition { get; set; }
		public Query(string fields, string tables, string condition = "")
		{
			Fields = fields;
			Tables = tables;
			Condition = condition;
		}
		public override string ToString()
		{
			string query = $"SELECT {Fields} FROM {Tables}";
			if (Condition != "") query += $" WHERE {Condition}";

			return query;
		}
	}
}
