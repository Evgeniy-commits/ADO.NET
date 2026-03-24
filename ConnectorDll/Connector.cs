using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConnectorDll
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

		public void Select(string cmd)
		{
			connection.Open();
			SqlCommand command = new SqlCommand(cmd, connection);

			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
				Console.Write(reader.GetName(i) + "\t\t");
			Console.WriteLine();
			while (reader.Read())
			{
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write($"{reader[i]}\t\t");
				Console.WriteLine();
			}
			reader.Close();
			connection.Close();
		}

		public void Select(string fields, string tables, string condition = "")
		{
			string cmd = $"SELECT {fields} FROM {tables}";
			if (condition != "") cmd += $" WHERE {condition}";
			cmd += ";";
			Select(cmd);
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
