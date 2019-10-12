using PreExam1ADO.Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PreExam1ADO.Gui
{
	public partial class FormBooks : Form
	{
		public FormBooks()
		{
			InitializeComponent();
		}

		private void FormBooks_Load(object sender, EventArgs e)
		{
			Books book = new Books();
			dataGridView1.DataSource = book.ReadBooks();
			textBoxIsbn.Enabled = false;
		}

		private void buttonAdd_Click(object sender, EventArgs e)
		{
			if (textBoxTitle.Text == "" || textBoxAuthor.Text == "" )
			{
				MessageBox.Show("Your information cannot be saved", "Error");
			}
			else
			{
				Books book = new Books();
				book.Title = textBoxTitle.Text;
				book.Author = textBoxAuthor.Text;
				if (book.SaveRecord(book))
				{
					MessageBox.Show("Your information has been saved", "Confirmation");
				}
				else
				{
					MessageBox.Show("Your information cannot be saved", "Error");
				}
			}
		}

		private void buttonRefresh_Click(object sender, EventArgs e)
		{
			Books book = new Books();
			dataGridView1.DataSource = book.ReadBooks();
			textBoxAuthor.Clear();
			textBoxIsbn.Clear();
			textBoxTitle.Clear();
			textBoxSearchTitle.Clear();
			textBoxSearchAuthor.Clear();
		}

		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.RowIndex >= 0)
			{
				DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
				textBoxTitle.Text = row.Cells["title"].Value.ToString();
				textBoxAuthor.Text = row.Cells["author"].Value.ToString();
				textBoxIsbn.Text = row.Cells["isbn"].Value.ToString();
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void buttonDelete_Click(object sender, EventArgs e)
		{
			if (textBoxAuthor.Text == "" || textBoxTitle.Text == "")
			{
				MessageBox.Show("Cannot Delete.... Something went Wrong");
			}
			else
			{
				Books book = new Books();
				book.ISBN = Convert.ToInt16(textBoxIsbn.Text);
				book.Title = textBoxTitle.Text;
				book.Author = textBoxAuthor.Text;

				if (book.DeleteRecord(book))
				{
					MessageBox.Show("The Selected Row is now Deleted......");
				}
				else
				{
					MessageBox.Show("Something went wrong......");
				}
			}
			buttonRefresh_Click(sender, e);
		}

		private void buttonUpdate_Click(object sender, EventArgs e)
		{
			if (textBoxAuthor.Text == "" || textBoxTitle.Text == "")
			{
				MessageBox.Show("Cannot Update.... Something went Wrong");
			}
			else
			{
				Books book = new Books();
				book.ISBN = Convert.ToInt16(textBoxIsbn.Text);
				book.Title = textBoxTitle.Text;
				book.Author = textBoxAuthor.Text;

				if (book.UpdateRecord(book))
				{
					MessageBox.Show("The Selected Row is now Updated......");
				}
				else
				{
					MessageBox.Show("Something went wrong......");
				}
			}
			buttonRefresh_Click(sender, e);
		}

		private void buttonSearch_Click(object sender, EventArgs e)
		{
			if (textBoxSearchTitle.Text == "" && textBoxSearchAuthor.Text == "")
			{
				MessageBox.Show("Search is Empty.............");
			}
			else
			{
				Books book = new Books();
				if (textBoxSearchAuthor.Text == "")
				{
					book.Title = textBoxSearchTitle.Text;
				}
				else
				{
					book.Author = textBoxSearchAuthor.Text;
				}

				var dt = book.SearchBook(book);


				if (dt.Rows.Count > 0)
				{
					dataGridView2.DataSource = book.SearchBook(book);
				}
				else
				{
					MessageBox.Show("Book is not Present.............");
				}
				textBoxSearchTitle.Text = "";
				textBoxSearchAuthor.Text = "";
			}
		}
	}
}
