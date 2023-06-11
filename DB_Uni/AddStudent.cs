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
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            string name = textBox1.Text;
            string dad = textBox2.Text;
            string num = textBox3.Text;
            string phone = textBox4.Text;
            string scode = textBox5.Text;

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
            sc.Open();
            string query = "INSERT INTO students (name,نام_پدر,شماره_شناسنامه,phone,scode) VALUES (N'" + name + "',N'" + dad + "','" + num + "','" + phone + "','" + scode + "')";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show(" !اطلاعات باموفقیت افزوده شد");
            textBox1.Text = textBox2.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }    
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
