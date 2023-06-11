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
    public partial class AddProfessor : Form
    {
        public AddProfessor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            { 
            string name = textBox1.Text;
            string num = textBox3.Text;
            string sex = textBox4.Text;
            string Degree = textBox5.Text;

            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
            sc.Open();
            string query = "INSERT INTO professors (name,کد_ملی,جنسیت,مدرک_تحصیلی) VALUES (N'" + name + "','" + num + "',N'" + sex + "',N'" + Degree + "')";
            SqlCommand command = new SqlCommand(query, sc);
            command.ExecuteNonQuery();
            sc.Close();
            MessageBox.Show(" !اطلاعات باموفقیت افزوده شد");
            textBox1.Text = textBox3.Text = textBox4.Text = textBox5.Text = "";
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
