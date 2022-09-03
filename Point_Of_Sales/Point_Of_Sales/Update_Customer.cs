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
    public partial class Update_Customer : Form
    {
        Connection connection;
        private int cust_id;
        public Update_Customer()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtCity.Clear();
            txtCode.Clear();
            txtEmail.Clear();
            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();
            txtStreet.Clear();
            txtSuburb.Clear();
        }

        public void setUpdate(int id, string city, string code, string email, string fname, string lname, string phone, string street, string suburb)
        {
            cust_id = id;
            txtCity.Text = city;
            txtCode.Text = code;
            txtEmail.Text = email;
            txtFName.Text = fname;
            txtLName.Text = lname;
            txtPhone.Text = phone;
            txtStreet.Text = street;
            txtSuburb.Text = suburb;
        }

        private bool validateEmail(string email)
        {
            int count1 = 0;
            int count2 = 0;

            foreach (char x in email)
            {
                if (x.Equals('.'))
                {
                    count1++;
                }
                if (x.Equals('@'))
                {
                    count2++;
                }
            }

            if (count1 < 1)
            {
                MessageBox.Show("Invalid email");
                return false;
            }

            if (count2 != 1)
            {
                MessageBox.Show("Invalid email");
                return false;
            }
            return true;
        }

        private bool validatePhone(string phone)
        {
            if (phone.Length != 10)
            {
                MessageBox.Show("A phone number must be 10 digits long");
                return false;
            }

            if (!phone[0].Equals('0'))
            {
                MessageBox.Show("A phone must start with a 0");
                return false;
            }

            try
            {
                Int64 x = Int64.Parse(phone);
            }
            catch
            {
                MessageBox.Show("A phone number must only contain digits");
                return false;
            }
            return true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtCity.Text.Equals("") || txtCode.Text.Equals("") || txtEmail.Text.Equals("") || txtFName.Text.Equals("") || txtLName.Text.Equals("") || txtPhone.Text.Equals("") || txtStreet.Text.Equals("") || txtSuburb.Text.Equals(""))
            {
                MessageBox.Show("Fill in all the required inputs");
                return;
            }

            if (!validateEmail(txtEmail.Text))
                return;

            if (!validatePhone(txtPhone.Text))
                return;

            int code;
            try
            {
                code = int.Parse(txtCode.Text);
                if (txtCode.Text.Length < 4)
                {
                    MessageBox.Show("Invalid Postal Code");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Postal Code should be digit values");
                return;
            }

            try
            {
                customerTableAdapter.UpdateQuery(txtFName.Text, txtLName.Text, txtEmail.Text, txtPhone.Text, txtStreet.Text, txtSuburb.Text, txtCity.Text, txtCode.Text, cust_id, cust_id);
                MessageBox.Show("Customer updated successfully");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Update_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupDataset.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
