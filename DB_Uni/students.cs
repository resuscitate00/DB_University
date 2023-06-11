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
    public partial class students : Form
    {
        AddStudent ads = new AddStudent();
        StuPhone stu = new StuPhone();
        SList sl = new SList();
        public students()
        {
            InitializeComponent();
            stu.s = this;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ads.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                string scode = textBox1.Text.ToString();
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
                sc.Open();
                string query = "DELETE FROM students WHERE scode ='" + scode + "'";
                SqlCommand command = new SqlCommand(query, sc);
                command.ExecuteNonQuery();
                sc.Close();
                MessageBox.Show("!اطلاعات با موفقیت حذف شد");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void students_Load(object sender, EventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                string scode = textBox1.Text.ToString();
                string name= textBox1.Text.ToString();
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
                con.Open();
                string query = "SELECT phone FROM students WHERE scode='" + scode  + "'";
                SqlCommand command = new SqlCommand(query, con);

                SqlDataReader rd = command.ExecuteReader();

                while (rd.Read())
                {
                    string phone = rd["phone"].ToString();
                    MessageBox.Show(phone);
                }

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

            try
            {
                string stcode = textBox1.Text;
                SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
                sc.Open();
                string query = "SELECT scode FROM students WHERE scode = '" + stcode + "'";
                SqlCommand cmd = new SqlCommand(query, sc);
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                string scode = reader["scode"].ToString();
                if (scode == stcode)
                {
                    stu.ShowDialog();         
                }
              
                sc.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Close();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            sl.ShowDialog();
        }
    }
}
