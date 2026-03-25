using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using DBtools;
using System.Configuration;

namespace DLLtest
{
	internal class ProgramTest
	{
		static void Main(string[] args)
		{
			DBtools.Connector connector = new DBtools.Connector
				(
				ConfigurationManager.ConnectionStrings["Movies_PV_521"].ConnectionString
				);
			connector.Select("SELECT * FROM Directors");

			DBtools.Connector academy_connector = new DBtools.Connector
				(
				ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString
				);
			academy_connector.Select("SELECT * FROM Disciplines");
		}
	}
}
