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
    public partial class Transact : Form
    {
        Connection connection;
        public Transact()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            LogIn x = new LogIn();
            x.Show();
            this.Hide();
        }

        private void productsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.productsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Transact_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Sales' table. You can move, or remove it, as needed.
            this.salesTableAdapter.Fill(this.groupDataset.Sales);
            // TODO: This line of code loads data into the 'groupDataset.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.groupDataset.Payments);
            // TODO: This line of code loads data into the 'groupDataset.Product_Sale' table. You can move, or remove it, as needed.
            this.product_SaleTableAdapter.Fill(this.groupDataset.Product_Sale);
            // TODO: This line of code loads data into the 'groupDataset.Product_Sale' table. You can move, or remove it, as needed.
            this.product_SaleTableAdapter.Fill(this.groupDataset.Product_Sale);
            // TODO: This line of code loads data into the 'groupDataset.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.groupDataset.Products);

        }

        private void productsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.RowIndex >= productsDataGridView.Rows.Count)
                return;
            int prod_id = int.Parse(productsDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            int quant = int.Parse((productsDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString()));


            if(doesExist(prod_id))
            {
                //This means that the item is already in the sales dataGridView
                //All we have to do is increment it's quantity and total
                int q = 1 + getQuantity(prod_id);
                if(quant - q < 0)
                {
                    MessageBox.Show("There are no more " + productsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() + "'s left");
                    return;
                }
                try
                {
                    decimal t = q * decimal.Parse(productsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
                    saleDataGridView.Rows[e.RowIndex].Cells[2].Value = q;
                    saleDataGridView.Rows[e.RowIndex].Cells[3].Value = t;
                    calculate();
                }catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                return;
            }
            //This means that the item does not exist in the sales data grid view, so we have to add it
            string prod_name = productsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            int quantity = 1;
            if (quant - quantity < 0)
            {
                MessageBox.Show("There are no more " + productsDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString() + "'s left");
                return;
            }
            decimal total = quantity * decimal.Parse(productsDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
            saleDataGridView.Rows.Add(prod_id, prod_name, quantity, total);
            calculate();
        }

        private int getQuantity(int id)
        {
            int q = 0;
            foreach(DataGridViewRow row in saleDataGridView.Rows)
            {
                int prod_id = int.Parse(row.Cells[0].Value.ToString());
                if(prod_id == id)
                {
                    q += int.Parse(row.Cells[2].Value.ToString());
                }
            }
            return q;
        }

        private bool doesExist(int id)
        {
            bool val = false;
            foreach(DataGridViewRow row in saleDataGridView.Rows)
            {
                int prod_id = int.Parse(row.Cells[0].Value.ToString());
                if(prod_id == id)
                {
                    val = true;
                }
            }
            return val;
        }

        private void calculate()
        {
            if (saleDataGridView.Rows.Count == 0)
            {
                txtTotal.Text = "0";
                txtSubtotal.Text = "0";
                txtVat.Text = "0";
                txtAmountPaid.Text = "0";
                txtChange.Text = "0";
                txtQuantity.Text = "0";
                return;
            }
            decimal total = 0;
            int quantity = 0;
            foreach (DataGridViewRow row in saleDataGridView.Rows)
            {
                total += decimal.Parse(row.Cells[3].Value.ToString());
                quantity += int.Parse(row.Cells[2].Value.ToString());
            }
            txtSubtotal.Text = (total - (total * (decimal)0.15)).ToString();
            txtVat.Text = (total * (decimal)0.15).ToString();
            txtTotal.Text = total.ToString();
            txtQuantity.Text = quantity.ToString();
            txtChange.Text = "-" + txtTotal.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if(!txtAmountPaid.Text.Equals("0") && !txtChange.Text.Substring(0, 1).Equals("-") && txtAmountPaid.Text.Length > 2)
            {
                MessageBox.Show("Too Much Money");
            }else
            {
                Button b = (Button)sender;
                string txt = b.Text;
                if (txtAmountPaid.Text.Equals("0"))
                {
                    if (txt.Equals(","))
                    {
                        txtAmountPaid.Text = "0,0";
                    }
                    txtAmountPaid.Text = txt;
                    calvulateChange();
                    return;
                }
                if (txt.Equals(","))
                {
                    if (txtAmountPaid.Text.Contains(","))
                        return;
                    txtAmountPaid.Text = txtAmountPaid.Text + ",0";
                    calvulateChange();
                    return;
                }
                txtAmountPaid.Text = txtAmountPaid.Text + txt;
                calvulateChange();
            }
        }

        private void calvulateChange()
        {
            decimal total = decimal.Parse("-" + txtTotal.Text);
            decimal change = total + decimal.Parse(txtAmountPaid.Text);
            txtChange.Text = change.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtAmountPaid.Text = "0";
            txtChange.Text = "-" + txtTotal.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if(saleDataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Select a product to remove");
                return;
            }
            DataGridViewRow row = saleDataGridView.SelectedRows[0];
            saleDataGridView.Rows.Remove(row);
            calculate();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            saleDataGridView.Rows.Clear();
            calculate();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                productsTableAdapter.FillBySearch(groupDataset.Products, txtSearch.Text);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtSearch.Text = "";
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {

            if(!txtPaymentMethod.Items.Contains(txtPaymentMethod.Text))
            {
                MessageBox.Show("Select a payment method from the provided list");
                return;
            }

            decimal change = decimal.Parse(txtChange.Text);
            int num_of_products = saleDataGridView.Rows.Count;
            decimal amount_paid = decimal.Parse(txtAmountPaid.Text);
            int quantity = int.Parse(txtQuantity.Text);
            decimal subtotal = decimal.Parse(txtSubtotal.Text);
            decimal vat = decimal.Parse(txtVat.Text);
            decimal total = decimal.Parse(txtTotal.Text);

            if(num_of_products <= 0)
            {
                MessageBox.Show("There are no products selected. Could not complete transaction");
                return;
            }
            if(change < 0)
            {
                MessageBox.Show("The amount paid is less than the amount owed. Could not complete transaction");
                return;
            }

            int cust_id = 1; //1 is the a customer representative of the POS System, indicating that the transaction was completed using the on campus system.

            salesTableAdapter.Insert(Connection.EMP_ID, quantity, txtPaymentMethod.Text, subtotal, vat, total);
            int sale_id = connection.getSaleID();

            foreach(DataGridViewRow row in saleDataGridView.Rows)
            {
                int p_quantity = int.Parse(row.Cells[2].Value.ToString());
                int p_id = int.Parse(row.Cells[0].Value.ToString());
                product_SaleTableAdapter.Insert(sale_id, p_id, p_quantity);
                connection.updateProduct(p_id, p_quantity);
            }

            paymentsTableAdapter.Insert(sale_id, cust_id, Connection.EMP_ID, txtPaymentMethod.Text, subtotal, vat, total, DateTime.Now);

            MessageBox.Show("Transaction Complete");
            productsTableAdapter.Fill(groupDataset.Products);
            clear();
        }

        private void clear()
        {
            saleDataGridView.Rows.Clear();
            calculate();

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
