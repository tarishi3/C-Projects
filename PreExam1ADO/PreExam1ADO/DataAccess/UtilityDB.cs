using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PreExam1ADO.DataAccess
{
	public class UtilityDB
	{
		public static SqlConnection ConnectDB()
		{
			SqlConnection connDB = new SqlConnection("data source =. ; database = sample ; Integrated Security = SSPI");
			connDB.Open();
			return connDB;
		}
	}
}
