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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LogIn x = new LogIn();
            x.Show();
            this.Hide();
        }

        private void transactToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Transact x = new Transact();
            x.MdiParent = this;
            x.Show();
        }
    }
}
