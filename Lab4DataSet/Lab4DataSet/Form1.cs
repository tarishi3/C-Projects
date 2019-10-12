using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab4DataSet
{
    public partial class Form1 : Form
    {
        DataSet dscollegeDB;
        DataTable dtStudents;
        SqlDataAdapter da;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnection connDB = new SqlConnection("data source=.; database=sample; Integrated Security=SSPI");
            dscollegeDB = new DataSet("collegeDB");
            dtStudents = new DataTable("Students");
            dtStudents.Columns.Add("StudentId",typeof(Int32));
            dtStudents.Columns.Add("FirstName", typeof(String));
            dtStudents.Columns.Add("LastName", typeof(String));
            dtStudents.Columns.Add("Email", typeof(String));
            dtStudents.PrimaryKey = new DataColumn[] { dtStudents.Columns["StudentId"] };
            dscollegeDB.Tables.Add(dtStudents);
            da = new SqlDataAdapter("select * from Students",connDB);
            da.Fill(dscollegeDB.Tables["Students"]);
            dataGridView1.DataSource = dtStudents;
        }

        private void refresh() {
            txtemail.Text = string.Empty;
            txtId.Text = string.Empty;
            txtlname.Text = string.Empty;
            txtfname.Text = string.Empty;
            txtSearch.Text = string.Empty;
            txtId.Enabled = true;
        }

        private void buttonInsert_Click(object sender, EventArgs e)
        {
            SqlConnection connDB = new SqlConnection("data source=.; database=sample; Integrated Security=SSPI");

            int studentId = Convert.ToInt32(txtId.Text);
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string email = txtemail.Text;
            dtStudents.Rows.Add(studentId, fname, lname, email);
            string que = string.Format("Insert into Students values ({0}, '{1}', '{2}', '{3}')",studentId, fname, lname, email);
            da.InsertCommand = new SqlCommand(que, connDB);
            da.Update(dscollegeDB, "Students");
            connDB.Close();
            refresh();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) {
                DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];
                txtId.Text = row.Cells["StudentId"].Value.ToString();
                txtfname.Text = row.Cells["Firstname"].Value.ToString();
                txtlname.Text = row.Cells["LastName"].Value.ToString();
                txtemail.Text = row.Cells["Email"].Value.ToString();
            }
            txtId.Enabled = false;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connDB = new SqlConnection("data source=.; database=sample; Integrated Security=SSPI");

            int studentId = Convert.ToInt32(txtId.Text);
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string email = txtemail.Text;
            DataRow dr = dtStudents.Rows.Find(studentId);
            dr["FirstName"] = fname;
            dr["LastName"] = lname;
            dr["Email"] = email;
            string que = string.Format("Update Students set FirstName = '{1}', LastName = '{2}', Email = '{3}' where StudentId = {0}", studentId, fname, lname, email);
            da.UpdateCommand = new SqlCommand(que, connDB);
            da.Update(dscollegeDB, "Students");
            connDB.Close();
            refresh();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connDB = new SqlConnection("data source=.; database=sample; Integrated Security=SSPI");

            int studentId = Convert.ToInt32(txtId.Text);
            string fname = txtfname.Text;
            string lname = txtlname.Text;
            string email = txtemail.Text;
            DataRow dr = dtStudents.Rows.Find(studentId);
            dr.Delete();
            string que = string.Format("Delete from Students where StudentId = {0}", studentId);
            da.DeleteCommand = new SqlCommand(que, connDB);
            da.Update(dscollegeDB, "Students");
            connDB.Close();
            refresh();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connDB = new SqlConnection("data source=.; database=sample; Integrated Security=SSPI");

            string fname = txtSearch.Text;
            DataTable newStudentTable = new DataTable();
            DataTable dtstudent2 = new DataTable();

            dtstudent2 = dtStudents.Copy();
            newStudentTable = dtStudents.Copy();

            newStudentTable.Clear();

            if (dscollegeDB.Tables.Contains("newStudentTable") == false)
            {
                dscollegeDB.Tables.Add("newStudentTable");
            }
            foreach (DataRow row in dtstudent2.Rows)
            {
                if (row["Firstname"].ToString() == fname)
                {
                    newStudentTable.ImportRow(row);
                }
            }

            //string que = string.Format("Select * from Students where FirstName = '{0}'", fname);
            //da.SelectCommand = new SqlCommand(que, connDB);
            //da.Fill(dscollegeDB.Tables["newStudentTable"]);
            dataGridView2.DataSource = newStudentTable;
            connDB.Close();
            refresh();
        }
    }
}
