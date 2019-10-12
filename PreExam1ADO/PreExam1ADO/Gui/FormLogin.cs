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
	public partial class FormLogin : Form
	{
		public FormLogin()
		{
			InitializeComponent();
		}

		private void buttonLogin_Click(object sender, EventArgs e)
		{
			if (textBoxUser.Text == "" || textBoxPass.Text == "")
			{
				MessageBox.Show("Please Enter Username or Password");
			}
			else
			{
				Login user = new Login();
				user.User = textBoxUser.Text;
				user.Password = textBoxPass.Text;

				if (user.ReadUser(user))
				{
					this.Hide();
					FormBooks cb = new FormBooks();
					cb.Show();
				}
				else
				{
					MessageBox.Show("Invalid username or password");
				}
			}
		}
	}
}
