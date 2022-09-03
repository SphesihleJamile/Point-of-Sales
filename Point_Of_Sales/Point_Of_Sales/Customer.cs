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
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Customer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.groupDataset.Customer);

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Payments x = new Payments();
            x.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Sales x = new Sales();
            x.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Products x = new Products();
            x.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Product_sales x = new Product_sales();
            x.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Employee x = new Employee();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                customerTableAdapter.Fill(groupDataset.Customer);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Customer x = new Add_Customer();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Equals(""))
            {
                MessageBox.Show("Select a customer before you continue");
                return;
            }
            Update_Customer x = new Update_Customer();
            x.setUpdate(int.Parse(txtID.Text), txtCity.Text, txtCode.Text, txtEmail.Text, txtFName.Text, txtLName.Text, txtPhone.Text, txtStreet.Text, txtSuburb.Text);
            x.Show();
        }
    }
}
