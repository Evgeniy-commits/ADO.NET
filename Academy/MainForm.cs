using System;
using System.Collections.Generic;
using System.ComponentModel;
//using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		DBtools.Connector connector;
		public MainForm()
		{
			InitializeComponent();
			connector = new DBtools.Connector
				(
					System.Configuration.ConfigurationManager.ConnectionStrings["PV_521_Import"].ConnectionString
				);
			dgvDirections.DataSource = connector.Select("*", "Directions");
		}
	}
}
