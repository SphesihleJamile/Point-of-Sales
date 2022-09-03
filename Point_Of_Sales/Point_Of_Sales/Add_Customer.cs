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
    public partial class Add_Customer : Form
    {
        Connection connection;
        public Add_Customer()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool validateEmail(string email)
        {
            int count1 = 0;
            int count2 = 0;

            foreach(char x in email)
            {
                if(x.Equals('.'))
                {
                    count1++;
                }
                if(x.Equals('@'))
                {
                    count2++;
                }
            }

            if(count1 < 1)
            {
                MessageBox.Show("Invalid email");
                return false;
            }

            if(count2 != 1)
            {
                MessageBox.Show("Invalid email");
                return false;
            }

            if(!connection.checkCustEmail(txtEmail.Text))
            {
                MessageBox.Show("Email already exxists");
                return false;
            }
            return true;
        }

        private bool validatePhone(string phone)
        {
            if(phone.Length != 10)
            {
                MessageBox.Show("A phone number must be 10 digits long");
                return false;
            }

            if(!phone[0].Equals('0'))
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

            if(!connection.checkCustPhone(txtPhone.Text))
            {
                MessageBox.Show("Phone already exists");
                return false;
            }
            return true;
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

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtCity.Text.Equals("") || txtCode.Text.Equals("") || txtEmail.Text.Equals("") || txtFName.Text.Equals("") || txtLName.Text.Equals("") || txtPhone.Text.Equals("") || txtStreet.Text.Equals("") || txtSuburb.Text.Equals(""))
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
                if(txtCode.Text.Length < 4)
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
                string password = txtPhone.Text.Substring(0, 5) + txtFName.Text;
                customerTableAdapter.Insert(txtFName.Text, txtLName.Text, txtEmail.Text, txtPhone.Text, txtStreet.Text, txtSuburb.Text, txtCity.Text, txtCode.Text, password);
                DialogResult res = MessageBox.Show("Customer inserted successfully. Would you like to insert another customer ?", "", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    button3_Click(sender, e);
                    return;
                }
                this.Hide();
            }catch(Exception ex)
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

        private void Add_Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupDataset.Customer);

        }
    }
}
