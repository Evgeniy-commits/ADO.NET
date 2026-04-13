using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBtools
{
    public class Connector
    {
		string connection_string;
		SqlConnection connection;

		public Connector(string connection_string)
		{
			Console.WriteLine(connection_string);
			this.connection_string = connection_string;
			connection = new SqlConnection(connection_string);
		}

		public DataTable Select(string cmd)
		{
			DataTable table = new DataTable();
			connection.Open();
			SqlCommand command = new SqlCommand(cmd, connection);

			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
				{ 
					Console.Write(reader.GetName(i) + "\t\t"); 
					table.Columns.Add(reader.GetName(i));
				}
			Console.WriteLine();
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
					{	
						row[i] = reader[i];
						Console.Write($"{reader[i]}\t\t");
					}
				Console.WriteLine();
				table.Rows.Add(row);
			}
			reader.Close();
			connection.Close();
			return table;
		}

		public DataTable Select(string fields, string tables, string condition = "")
		{
			string cmd = $"SELECT {fields} FROM {tables}";
			if (condition != "") cmd += $" WHERE {condition}";
			cmd += ";";
			return Select(cmd);
		}
		public Dictionary<string, int> GetDictionary(string table, string condition = "")
		{
			Dictionary<string, int> dictionary = new Dictionary<string, int>();
			string cmd = $"SELECT {table.Substring(0, table.Length - 1)}_name, {table.Substring(0, table.Length - 1)}_id FROM {table}";
			if (condition != "") cmd += $" WHERE {condition}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				dictionary.Add(reader[0].ToString(), Convert.ToInt32(reader[1]));
			}
			reader.Close();
			connection.Close();
			return dictionary;
		}
		public object Scalar(string cmd)
		{
			object result = null;
			connection.Open();
			SqlCommand command = new SqlCommand(cmd, connection);
			result = command.ExecuteScalar(); // выполнение скалярного запроса
			Console.WriteLine();
			connection.Close();
			return result;
		}

		public int GetMaxPrimaryKey(string table)
		{
			string cmd = $"SELECT * FROM {table}";
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			SqlDataReader reader = command.ExecuteReader();
			string pk_name = reader.GetName(0);
			reader.Close();
			connection.Close();
			return (int)Scalar($"SELECT MAX({pk_name}) FROM {table}");
		}
		public int GetNextPrimaryKey(string table)
		{
			return GetMaxPrimaryKey(table) + 1;
		}

		public string GetPrimaryKeyColumnName(string table)
		{
			string cmd = $@"SELECT INFORMATION_SCHEMA.KEY_COLUMN_USAGE.COLUMN_NAME
							FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
							WHERE TABLE_NAME = N'{table}' 
							AND CONSTRAINT_NAME LIKE N'PK_%'";
			return (string)Scalar(cmd);
		}
		public void Insert(string cmd)
		{
			SqlCommand command = new SqlCommand(cmd, connection);
			connection.Open();
			try
			{
				command.ExecuteNonQuery();
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.GetType());
				Console.WriteLine(ex.Message);
				if (ex.GetType() == typeof(SqlException) && ex.Message.Contains("_id"))
					Console.WriteLine("Good");
			}
			connection.Close();
		}

		public void Insert(string table, string fields, string values)
		{
			string condition = "";
			string[] s_fields = fields.Split(',');
			string[] s_values = values.Split(',');
			string parsed_values = $"N'{s_values[0]}',";
			for (int i = 1; i < s_fields.Length; i++)
			{
				condition += $" {s_fields[i]} = N'{s_values[i]}' ";
				parsed_values += s_values[i][0] != 'N' && s_values[i][1] != '\'' ? $"N'{s_values[i]}'" : s_values[i];
				if (i != s_fields.Length - 1)
				{
					condition += "AND";
					parsed_values += ",";
				}
			}
			string cmd = $"IF NOT EXISTS (SELECT {GetPrimaryKeyColumnName(table)} FROM {table} WHERE {condition})";
			cmd += $"INSERT {table}({fields}) VALUES ({parsed_values})";
			Insert(cmd);
		}
	}
}
