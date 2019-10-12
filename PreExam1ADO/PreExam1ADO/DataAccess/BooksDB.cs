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
	public class BooksDB
	{
		public static SqlConnection connDB = UtilityDB.ConnectDB();
		public static SqlCommand cmd = new SqlCommand();

		public static DataTable ReadBooks()
		{
			if (connDB.State == ConnectionState.Closed)
			{
				connDB = UtilityDB.ConnectDB();
				cmd = new SqlCommand();
			}
			cmd.Connection = connDB;
			cmd.CommandText = "select * from book";
			SqlDataReader reader = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(reader);
			reader.Close();
			cmd.Dispose();
			connDB.Close();
			return dt;
		}

		public static bool SaveRecord(Books book)
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
				cmd.CommandText = string.Format("Insert into book(title,author) values('{0}','{1}')", book.Title, book.Author);
				cmd.ExecuteNonQuery();
				connDB.Close();
			}
			catch (Exception)
			{
				result = false;
			}
			return result;

		}

		public static bool UpdateRecord(Books book)
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
				cmd.CommandText = string.Format("Update book set title = '{1}', author = '{2}' where Isbn = {0}", book.ISBN, book.Title, book.Author);
				cmd.ExecuteNonQuery();
				connDB.Close();
			}
			catch (Exception)
			{
				result = false;
			}
			return result;

		}

		public static bool DeleteRecord(Books book)
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
				cmd.CommandText = string.Format("Delete from book where Isbn = {0}", book.ISBN);
				cmd.ExecuteNonQuery();
				connDB.Close();
			}
			catch (Exception)
			{
				result = false;
			}
			return result;

		}

		public static DataTable SearchBook(Books book)
		{
			if (connDB.State == ConnectionState.Closed)
			{
				connDB = UtilityDB.ConnectDB();
				cmd = new SqlCommand();
			}
			cmd.Connection = connDB;
			cmd.CommandText = String.Format("select * from book where title = '{0}' or author = '{1}'", book.Title, book.Author);
			SqlDataReader reader = cmd.ExecuteReader();
			DataTable dt = new DataTable();
			dt.Load(reader);
			reader.Close();
			cmd.Dispose();
			connDB.Close();
			return dt;
		}
	}
}
