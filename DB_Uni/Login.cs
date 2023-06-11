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
    public partial class LoginForm : Form
       
    {
        Home h = new Home();
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
         try
           {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
            sc.Open();
                string query = "SELECT password FROM Users WHERE username = '" + username + "'";
            SqlCommand cmd = new SqlCommand(query, sc);
            SqlDataReader reader = cmd.ExecuteReader();
            reader.Read();
            string password = reader["password"].ToString();
                if (pass == password)
                {
                    h.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("INCORRECT");
            sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("INCORRECT");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string pass = textBox2.Text;
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
            sc.Open();
            string query = "INSERT INTO Users (username,password) VALUES ('" + username + "','" + pass + "')";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show("!ثبت نام با موفقیت انجام شد ");
            textBox1.Text = textBox2.Text  = "";
        }
    }
}
