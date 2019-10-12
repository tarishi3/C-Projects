using PreExam1ADO.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PreExam1ADO.Business
{
	public class Books
	{
		private int isbn;
		private string title;
		private string author;
		public int ISBN { get => isbn; set => isbn = value; }
		public string Title { get => title; set => title = value; }
		public string Author { get => author; set => author = value; }

		public DataTable ReadBooks()
		{
			return BooksDB.ReadBooks();
		}

		public bool SaveRecord(Books book)
		{
			return BooksDB.SaveRecord(book);
		}

		public bool UpdateRecord(Books book)
		{
			return BooksDB.UpdateRecord(book);
		}

		public bool DeleteRecord(Books book)
		{
			return BooksDB.DeleteRecord(book);
		}

		public DataTable SearchBook(Books book)
		{
			return BooksDB.SearchBook(book);
		}

	}
}
