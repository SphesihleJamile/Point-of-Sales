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
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.groupDataset.Employee);

        }

        private void button21_Click(object sender, EventArgs e)
        {
            Customer x = new Customer();
            x.Show();
            this.Hide();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Product_sales x = new Product_sales();
            x.Show();
            this.Hide();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Products x = new Products();
            x.Show();
            this.Hide();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Sales x = new Sales();
            x.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Payments x = new Payments();
            x.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                employeeTableAdapter.Fill(groupDataset.Employee);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtID.Text.Equals(""))
            {
                MessageBox.Show("Select an employee before you continue");
                return;
            }
            Update_Staff x = new Update_Staff();
            x.setUpdate(int.Parse(txtID.Text), txtFName.Text, txtLName.Text, txtEmail.Text, txtPhone.Text, txtStreet.Text, txtCity.Text, txtCode.Text, txtRole.Text, txtContract.Text);
            x.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Staff x = new Add_Staff();
            x.Show();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employeeTableAdapter.FillBySearch(groupDataset.Employee, txtSearch.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
