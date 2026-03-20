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

			string cmd =
			@"SELECT movie_id, title, release_date, first_name, last_name 
			FROM Movies, Directors WHERE director = director_id";
			connector.Select(cmd);
			Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Movies")}");
			connector.Select("SELECT * FROM Directors");
			Console.WriteLine($"Количество записей: {connector.Scalar("SELECT COUNT(*) FROM Directors")}");
		}
	}
}
