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
			
			Connector connector = new Connector(connection_string);
			connector.Insert("INSERT Directors (first_name, last_name) VALUES (N'Guy', N'Richie'); ");
			Console.WriteLine($"PK Max:\t{connector.GetMaxPrimaryKey("Directors")}");

			string cmd =
			@"SELECT movie_id, title, release_date, first_name, last_name 
			FROM Movies, Directors WHERE director = director_id";
			//connector.Select(cmd);
			connector.Select("*", "Directors");
			Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Directors")}");
			//connector.Select("SELECT * FROM Directors");
			connector.Select
				(
					"title, release_date, first_name, last_name",
					"Movies, Directors",
					"director = director_id"
				);
			Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Movies")}");
		}
	}
}
