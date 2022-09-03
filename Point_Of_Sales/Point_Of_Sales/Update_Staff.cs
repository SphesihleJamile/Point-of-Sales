using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sales
{
    public partial class Update_Staff : Form
    {
        private int emp_ID = 0;
        public Update_Staff()
        {
            InitializeComponent();
        }

        public void setUpdate(int id, string fname, string lname, string email, string phone, string street, string city, string postal_code, string role, string contract)
        {
            this.emp_ID = id;
            txtFName.Text = fname;
            txtLName.Text = lname;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtStreet.Text = street;
            txtCity.Text = city;
            txtPostalCode.Text = postal_code;
            txtRole.Text = role;
            txtContract.Text = contract;
        }

        private bool validatePhone(string phone)
        {
            if (phone == null)
            {
                return false;
            }
            if (phone.Length != 10)
            {
                MessageBox.Show("Invalid phone number");
                return false;
            }
            Int64 p;
            try
            {
                p = Int64.Parse(phone);
            }
            catch
            {
                MessageBox.Show("Invalid phone number");
                return false;
            }
            return true;
        }

        private bool validateEmail(string email)
        {
            if (email.Length < 5)
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            int c1 = 0;
            int c2 = 0;
            foreach (char x in email)
            {
                if (x.Equals('@'))
                    c1++;
                if (x.Equals('.'))
                    c2++;
            }
            if (c1 < 1 || c2 < 1)
            {
                MessageBox.Show("Invalid Email");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCity.Text.Equals("") || txtContract.Text.Equals("") || txtEmail.Text.Equals("") || txtFName.Text.Equals("") || txtLName.Text.Equals("") || txtPhone.Text.Equals("") || txtPostalCode.Text.Equals("") || txtRole.Text.Equals("") || txtStreet.Text.Equals("") || txtSuburb.Text.Equals(""))
            {
                MessageBox.Show("Fill in all the required input");
                return;
            }
            else if (!validatePhone(txtPhone.Text))
            {
                return;
            }
            else if (!validateEmail(txtEmail.Text))
            {
                return;
            }
            //validate postal code
            int code;
            try
            {
                code = int.Parse(txtPostalCode.Text);
                if (txtPostalCode.Text.Length < 4)
                {
                    MessageBox.Show("Invalid postal code");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Invalid postal code");
                return;
            }
            //validate role
            if (!txtRole.Items.Contains(txtRole.Text))
            {
                MessageBox.Show("Invalid Rol");
                return;
            }
            if (!txtContract.Items.Contains(txtContract.Text))
            {
                MessageBox.Show("Invalid Contract");
                return;
            }
            //register new employee
            try
            {
                employeeTableAdapter1.UpdateQuery(txtFName.Text, txtLName.Text, txtEmail.Text, txtPhone.Text, txtStreet.Text, txtSuburb.Text, txtCity.Text, txtPostalCode.Text, txtRole.Text, txtContract.Text, emp_ID, emp_ID);
                MessageBox.Show("Employee successfully updated");
                this.Hide();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
