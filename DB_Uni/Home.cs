using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Uni
{
    public partial class Home : Form
    {
        students s = new students();
        professors p = new professors();
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            p.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();

        }
    }
}
