using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ADO
{
	internal class Connector
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
			int field = reader.FieldCount;
			string[] col = new string[field];
			for (int i = 0; i < reader.FieldCount; i++)
				col[i] = reader.GetName(i);
			//Console.Write(reader.GetName(i));
			Console.WriteLine();
			int row = 0;
			while (reader.Read()) row++;
			reader.Close();
			reader = command.ExecuteReader();
			string[][] data = new string[row][];
			
			int curRow = 0;
			while (reader.Read())
			{
				string[] numRow = new string[field];
				for (int i = 0; i < reader.FieldCount; i++)
				{
					object val = reader[i];
					if (val == null) numRow[i] = "";
					else
					{
						string strVal = val.ToString();
						numRow[i] = dateOnly(strVal);
					}
				}
					//numRow[i] = reader[i] == null ? "" : reader[i].ToString();
				//Console.Write($"{reader[i]}\t\t");
				//Console.WriteLine();
				data[curRow] = numRow;
				curRow++;
			}
			reader.Close();
			connection.Close();

			if (data.Length == 0)
			{
				Console.WriteLine("Нет данных");
				return;
			}

			int colCount = col.Length;
			int[] width = new int[colCount];
			for (int i = 0; i < colCount; i++)
				width[i] = col[i].Length;
			foreach (string[] dataRow in data)
			{
				for (int colIndex = 0; colIndex < colCount; colIndex++)
				{
					if (dataRow[colIndex].Length > width[colIndex])
						width[colIndex] = dataRow[colIndex].Length;

				}
			}

			for (int colIndex = 0; colIndex < colCount; colIndex++) 
				Console.Write(col[colIndex].PadRight(width[colIndex]) + "\t");
			Console.WriteLine();
			foreach (string[] dataRow in data)
			{
				for (int colIndex = 0; colIndex < colCount; colIndex++)
				{
					Console.Write(dataRow[colIndex].PadRight(width[colIndex]) + "\t");
				}
				Console.WriteLine();
			}
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
			return (GetMaxPrimaryKey(table) + 1);
		}
		public void Insert(string cmd)
		{ 

			SqlCommand command = new SqlCommand (cmd, connection);
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
				GetNextPrimaryKey(GetTableName(cmd));
			}
			finally
			{
				connection.Close();
			}
			//connection.Close();
		}

		public string GetTableName(string cmd)
		{
			SqlCommand command = new SqlCommand(cmd, connection);
			System.Text.RegularExpressions.Match match = System.Text.RegularExpressions.Regex.Match
			(cmd, @"INSERT\s+([\w\.]+)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
			connection.Close();
			return match.Success ? match.Groups[1].Value : null;
		}

		public string[] GetPrimaryKeyName(string tableName)
		{
			if (string.IsNullOrWhiteSpace(tableName)) Console.WriteLine("Имя не может быть пустым");

			string query = $@"SELECT COLUMN_NAME
				FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE
				WHERE OBJECTPROPERTY(OBJECT_ID(CONSTRAINT_SCHEMA + '.' + CONSTRAINT_NAME), 'IsPrimaryKey') = 1
				AND TABLE_NAME = N'{tableName}'
				AND TABLE_SCHEMA = 'dbo'
				ORDER BY ORDINAL_POSITION";

			string[] primaryKeyColumns = new string[0];
			int count = 0;

			connection.Open();
			SqlCommand command = new SqlCommand (query, connection);
			SqlDataReader reader = command.ExecuteReader();

			while (reader.Read())
			{
				string[] buf = new string[count + 1];
				for (int j = 0; j < primaryKeyColumns.Length; j++)
					buf[j] = primaryKeyColumns[j];
				primaryKeyColumns = buf;
				primaryKeyColumns[count] = reader.GetString(0);
				count++;
			}
			//Console.WriteLine($"Найдено первичных ключей: {primaryKeyColumns.Length}");
			reader.Close();
			command.Dispose();
			connection.Close();

			return primaryKeyColumns;
		}

		public string dateOnly (string input)
		{
			if (string.IsNullOrWhiteSpace(input)) return input;

			if (input.Contains(' '))
			{
				string date = input.Split(' ')[0];
				return date;
			}
			return input;
		}

	}
}
