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
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void salesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.salesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.groupDataset.Sales);

        }

        private void button13_Click(object sender, EventArgs e)
        {
            Transact x = new Transact();
            x.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                salesTableAdapter.Fill(groupDataset.Sales);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {
            Payments x = new Payments();
            x.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This feature has not yet been implemented");
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

        private void button21_Click(object sender, EventArgs e)
        {
            Customer x = new Customer();
            x.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Employee x = new Employee();
            x.Show();
            this.Hide();
        }
    }
}