using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WinFormsApp1
{
    public partial class form_log_up : Form
    {
        public form_log_up()
        {
            InitializeComponent();
        }
        string connition = ("Data Source = DESKTOP-O3UH2S9\\SQLEXPRESS; initial catalog = ahmed ; integrated security=true");
        SqlCommand cmd;
        private void button1_Click(object sender, EventArgs e)
        {



            SqlConnection sqlcon = new SqlConnection(connition);
            sqlcon.Open();
            cmd = new SqlCommand("insert into Table_1 values('" + textBox1.Text + "','" + textBox2.Text + "','" +textBox3.Text + "')", sqlcon);
            cmd.ExecuteNonQuery();
            MessageBox.Show(" Data Has saved in database ");
            sqlcon.Close();
            MessageBox.Show("data saved succefuly");
        
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
