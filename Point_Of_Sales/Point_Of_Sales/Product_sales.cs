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
    public partial class Product_sales : Form
    {
        Connection connection;
        public Product_sales()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void product_SaleBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.product_SaleBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Product_sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Product_Sale' table. You can move, or remove it, as needed.
            this.product_SaleTableAdapter.Fill(this.groupDataset.Product_Sale);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtSaleID.Text.Length == 0)
            {
                MessageBox.Show("Select a record before you continue");
                return;
            }
            List<String> det = connection.getProductInfo(int.Parse(txtProdID.Text));
            if(det == null)
            {
                MessageBox.Show("An error occured or this product is no longer available in the database");
                return;
            }
            txtProdName.Text = det[0];
            txtPrice.Text = det[1];
            txtAvailQuantity.Text = det[2];
            txtCategory.Text = det[3];
            txtDescription.Text = det[4];
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
