using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using PreExam1ADO.Business;

namespace PreExam1ADO.DataAccess
{
	public class UserDB
	{
		public static SqlConnection connDB = UtilityDB.ConnectDB();
		public static SqlCommand cmd = new SqlCommand();

		public static bool ReadUser(Login user)
		{
			bool result = true;
			try
			{
				if (connDB.State == ConnectionState.Closed)
				{
					connDB = UtilityDB.ConnectDB();
					cmd = new SqlCommand();
				}
				cmd.Connection = connDB;
				cmd.CommandText = string.Format("select * from users where user = '{0}' and pass = '{1}'", user.User, user.Password);
				SqlDataReader reader = cmd.ExecuteReader();
				DataTable dt = new DataTable();
				dt.Load(reader);
				reader.Close();
				cmd.Dispose();
				connDB.Close();
			}
			catch (Exception)
			{
				result = false;
			}
			
			return result;
		} 
	}
}
