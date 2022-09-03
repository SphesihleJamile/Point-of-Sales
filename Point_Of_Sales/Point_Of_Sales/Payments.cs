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
    public partial class Payments : Form
    {
        Connection connection;
        public Payments()
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

        private void paymentsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.paymentsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.groupDataset);

        }

        private void Payments_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'groupDataset.Payments' table. You can move, or remove it, as needed.
            this.paymentsTableAdapter.Fill(this.groupDataset.Payments);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                paymentsTableAdapter.Fill(groupDataset.Payments);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(txtEID.Text.Equals(""))
            {
                MessageBox.Show("Select a record before continuing");
                return;
            }

            int cid = int.Parse(txtCID.Text);
            int eid = int.Parse(txtEID.Text);

            List<string> det = connection.salesMoreDetails(cid, eid);
            txtCName.Text = det[0];
            txtCEmail.Text = det[1];
            txtEName.Text = det[2];
            txtEEmail.Text = det[3];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string total = "" + connection.getTotalPayments(dateTimePicker1.Value);
            if (total.Length > 3)
                txtTotal.Text = "R" + total.Substring(0, total.Length - 3);
            else
                txtTotal.Text = "R0";
        }
    }
}
