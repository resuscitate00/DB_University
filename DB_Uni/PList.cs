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
    public partial class PList : Form
    {
        public PList()
        {
            InitializeComponent();
        }

        private void PList_Load(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
                con.Open();
                string query = "SELECT name FROM professors";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())
                {
                    string name = rd["name"].ToString();
                    listBox1.Items.Add(name);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
