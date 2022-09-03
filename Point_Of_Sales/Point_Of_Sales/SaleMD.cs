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
    public partial class SaleMD : Form
    {
        Connection connection;
        List<string> details;
        public SaleMD()
        {
            InitializeComponent();
            connection = new Connection();
        }

        public void setDetails(int cust_ID, int emp_ID)
        {
            txtCID.Text = "" + cust_ID;
            txtEID.Text = "" + emp_ID;
            details = connection.salesMoreDetails(cust_ID, emp_ID);
            if(details != null)
            {
                txtCName.Text = details[0];
                txtCEmail.Text = details[1];
                txtEName.Text = details[2];
                txtEEmail.Text = details[3];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
