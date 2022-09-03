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
    public partial class Add_Product : Form
    {
        public Add_Product()
        {
            InitializeComponent();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Add_Product_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.groupDataset.Products);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtName.Text.Equals("") || txtCategory.Text.Equals("") || txtPrice.Text.Equals("") || txtQuantity.Text.Equals(""))
            {
                MessageBox.Show("Fill in all required data");
                return;
            }

            if(!txtCategory.Items.Contains(txtCategory.Text))
            {
                MessageBox.Show("The selected category does not exist");
                return;
            }

            decimal price;
            try
            {
                price = decimal.Parse(txtPrice.Text);
                if (price <= 0)
                {
                    MessageBox.Show("Price cannot be less than or equals to 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Price should only be integer values");
                return;
            }

            int quantity;
            try
            {
                quantity = int.Parse(txtQuantity.Text);
                if(quantity <= 0)
                {
                    MessageBox.Show("Quantity cannot be less than or equals to 0");
                    return;
                }
            }
            catch
            {
                MessageBox.Show("Quantity should only be integer values");
                return;
            }

            try
            {
                productsTableAdapter.Insert(txtName.Text, price, quantity, txtCategory.Text, txtDescription.Text, new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second));
                DialogResult res = MessageBox.Show("Product Added Successfully. Do you want to add another product ?", "", MessageBoxButtons.YesNo);
                if(res == DialogResult.Yes)
                {
                    button2_Click(sender, e);
                    return;
                }
                this.Hide();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCategory.Text = "";
            txtDescription.Clear();
            txtName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
        }
    }
}
