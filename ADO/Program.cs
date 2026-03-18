using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ADO
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string connection_string = "Data Source=(localdb)\\MSSQLLocalDB;" +
									   "Initial Catalog=Movies_PV_521;" +
									   "Integrated Security=True;" +
									   "Connect Timeout=30;Encrypt=False;" +
									   "TrustServerCertificate=False;" +
									   "ApplicationIntent=ReadWrite;" +
									   "MultiSubnetFailover=False";
			Console.WriteLine(connection_string);

			SqlConnection connection = new SqlConnection(connection_string);
			connection.Open();

			string cmd =
"SELECT movie_id, title, reliase_date, first_name, last_name FROM Movies, Directors WHERE director = director_id";
			SqlCommand command = new SqlCommand(cmd, connection);

			SqlDataReader reader = command.ExecuteReader();
			for (int i = 0; i < reader.FieldCount; i++)
				Console.Write(reader.GetName(i) + "\t\t");
			Console.WriteLine();
			while (reader.Read())
			{
				//Console.WriteLine($"{reader[0]}\t{reader[1]}\t{reader[2]}\t{reader[3]}");
				for (int i = 0; i < reader.FieldCount; i++)
					Console.Write($"{reader[i]}\t\t");
				Console.WriteLine();
			}
			reader.Close();
			command.CommandText = "SELECT COUNT(*) FROM Movies";
			Console.WriteLine($"Количество записей:\t{command.ExecuteScalar()}");
			connection.Close();
		}
	}
}
