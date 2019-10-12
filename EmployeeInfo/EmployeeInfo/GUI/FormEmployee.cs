using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeInfo.GUI
{
    public partial class FormEmployee : Form
    {
        EmployeeProjectDBEntities dBEntities = new EmployeeProjectDBEntities();
        public FormEmployee()
        {
            InitializeComponent();
        }

        private void clearTextBox()
        {
            txtID.Text = "";
            txtFname.Text = "";
            txtLname.Text = "";
            txtPhone.Text = "";
            txtEmail.Text = "";
            txtSearch.Text = "";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            
                
                Employee emp = new Employee();
                int id = Convert.ToInt32(txtID.Text.Trim());
                Employee emp1 = dBEntities.Employees.Find(id);
                if (emp1 != null)
                {
                    MessageBox.Show("Error!!");
                    txtID.Clear();
                    txtID.Focus();
                    return;
                }
                else
                {
                    emp.EmployeeId = id;
                }
                emp.FirstName = txtFname.Text.Trim();
                emp.LastName = txtLname.Text.Trim();
                emp.PhoneNumber = txtPhone.Text.Trim();
                emp.Email = txtEmail.Text.Trim();
                dBEntities.Employees.Add(emp);
                dBEntities.SaveChanges();
                MessageBox.Show("Saved Succesfully");
                clearTextBox();
            
            
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            var context = new EmployeeProjectDBEntities();
            var query1 = from c in context.Employees
                         select c;

            listView1.Items.Clear();
            foreach (var emp in query1)
            {
                ListViewItem item = new ListViewItem(Convert.ToString(emp.EmployeeId));
                item.SubItems.Add(emp.FirstName);
                item.SubItems.Add(emp.LastName);
                item.SubItems.Add(emp.PhoneNumber);
                item.SubItems.Add(emp.Email);
                listView1.Items.Add(item);
            }
            txtID.Enabled = true;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                ListViewItem item = listView1.SelectedItems[0];
                txtID.Text = item.SubItems[0].Text;
                txtFname.Text = item.SubItems[1].Text;
                txtLname.Text = item.SubItems[2].Text;
                txtPhone.Text = item.SubItems[3].Text;
                txtEmail.Text = item.SubItems[4].Text;
            }
            else
            {
                clearTextBox();
            }
            txtID.Enabled = false;
        }

        private void FormEmployee_Load(object sender, EventArgs e)
        {
            listView1.FullRowSelect = true;
            comboBoxSearch.Items.Add("EmployeeId");
            comboBoxSearch.Items.Add("FirstName");
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            
            Employee emp = new Employee();
            int id = Convert.ToInt32(txtID.Text.Trim());
            emp = dBEntities.Employees.Find(id);
            if (emp != null)
            {
                emp.EmployeeId = id;
                emp.FirstName = txtFname.Text.Trim();
                emp.LastName = txtLname.Text.Trim();
                emp.PhoneNumber = txtPhone.Text.Trim();
                emp.Email = txtEmail.Text.Trim();
                dBEntities.SaveChanges();
                MessageBox.Show("Updated Succesfully");
                clearTextBox();
            }
            buttonList_Click(sender, e);
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //EmployeeProjectDBEntities dBEntities = new EmployeeProjectDBEntities();
            Employee emp = new Employee();
            int id = Convert.ToInt32(txtID.Text.Trim());
            emp = dBEntities.Employees.Find(id);
            if (emp != null)
            {
                dBEntities.Employees.Remove(emp);
                dBEntities.SaveChanges();
                MessageBox.Show("Deleted Succesfully");
                clearTextBox();
            }
            buttonList_Click(sender, e);
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            var items = comboBoxSearch.Text;
            if (items == "EmployeeId")
            {
                int id = Convert.ToInt32(txtSearch.Text.Trim());
                var query1 = from c in dBEntities.Employees
                             where c.EmployeeId == id
                             select c;
                listView1.Items.Clear();
                foreach (var emp in query1)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(emp.EmployeeId));
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);
                    item.SubItems.Add(emp.PhoneNumber);
                    item.SubItems.Add(emp.Email);
                    listView1.Items.Add(item);
                }
            }
            else
            {
                string fname = txtSearch.Text.Trim();
                var query1 = from c in dBEntities.Employees
                             where c.FirstName == fname
                             select c;
                listView1.Items.Clear();
                foreach (var emp in query1)
                {
                    ListViewItem item = new ListViewItem(Convert.ToString(emp.EmployeeId));
                    item.SubItems.Add(emp.FirstName);
                    item.SubItems.Add(emp.LastName);
                    item.SubItems.Add(emp.PhoneNumber);
                    item.SubItems.Add(emp.Email);
                    listView1.Items.Add(item);
                }

            }
        }
    }
}
