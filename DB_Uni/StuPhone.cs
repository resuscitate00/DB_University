using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DB_Uni
{
    public partial class StuPhone : Form
    {
        public students s;
        public StuPhone()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nphone = textBox1.Text;
                string scode = s.textBox1.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
                sc.Open();
                string query = "UPDATE students SET phone='" + nphone + "' WHERE scode='" + scode + "'";
                SqlCommand command = new SqlCommand(query, sc);
                command.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("!!تغییرات موردنظر اعمال شد");
                textBox1.Text = "";
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
