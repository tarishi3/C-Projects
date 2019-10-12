using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using PreExam1ADO.DataAccess;

namespace PreExam1ADO.Business
{
	public class Login
	{
		private string user;
		private string pass;
		
		public string User { get => user; set => user = value; }
		public string Password { get => pass; set => pass = value; }

		public bool ReadUser(Login user)
		{
			return UserDB.ReadUser(user);
		}
	}
}
