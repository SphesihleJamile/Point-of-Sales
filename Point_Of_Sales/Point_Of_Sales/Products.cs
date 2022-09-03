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
    public partial class Products : Form
    {
        Connection connection;
        public Products()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Transact x = new Transact();
            x.Show();
            this.Hide();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Employee x = new Employee();
            x.Show();
            this.Hide();
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

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Products_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.groupDataset.Products);

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                productsTableAdapter.FillBySearch(groupDataset.Products, txtSearch.Text);
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                button13_Click(sender, e);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                productsTableAdapter.Fill(groupDataset.Products);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add_Product x = new Add_Product();
            x.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(txtProdID.Text.Equals(""))
            {
                MessageBox.Show("Select a product to continue");
                return;
            }
            Update_Product x = new Update_Product();
            x.setUpdate(int.Parse(txtProdID.Text), txtPName.Text, txtPrice.Text, txtCategory.Text, txtDescription.Text, txtQuantity.Text);
            x.Show();
        }
    }
}
