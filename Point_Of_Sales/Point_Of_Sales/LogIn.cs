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
    public partial class LogIn : Form
    {
        private Connection connection;
        public LogIn()
        {
            InitializeComponent();
            connection = new Connection();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Are you sure you want to close the application ?", "POS System", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(connection.LogIn(txtUsername.Text, txtPassword.Text))
            {
                MessageBox.Show("Log In Successful");
                Transact x = new Transact();
                x.Show();
                this.Hide();
                return;
            }
            MessageBox.Show("Invalid Login Credentials");
            txtPassword.Clear();
            txtPassword.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtPassword.Clear();
            txtUsername.Clear();
            txtUsername.Focus();
        }
    }
}
