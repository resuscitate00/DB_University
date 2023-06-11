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
    public partial class professors : Form
    {
        AddProfessor adp = new AddProfessor();
        PList pro = new PList();
        public professors()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            adp.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {            
            string num = textBox1.Text.ToString();
            SqlConnection sc = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Melika\source\repos\DB_Uni\DB_Uni\uni.mdf;Integrated Security=True");
            sc.Open();
            string query = "DELETE FROM professors WHERE کد_ملی='" + num + "'";
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

        private void professors_Load(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Home().Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            pro.ShowDialog(); 
        }
    }
}
