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

namespace db1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server = KELVIN\SQLEXPRESS;database= Login;Integrated Security =true");
            SqlCommand com1 = new SqlCommand("select LoginID,username, password,email from tLog where username = @user", con);
            
            string output="";
            con.Open();
            com1.Parameters.AddWithValue("@user", textBox1.Text);

            SqlDataReader dr1 = com1.ExecuteReader();
            if (dr1.HasRows == true)
            {
                dr1.Read();
                output = output + dr1.GetValue(0) + "-" + dr1.GetValue(1) + "-" + dr1.GetValue(2) + "-"+ dr1.GetValue(3) + "\n";

                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("You input wrong username");
            }

           

            dr1.Close();            
            com1.Dispose();           
            con.Close();
         }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server = KELVIN\SQLEXPRESS;database= Login;Integrated Security =true");
            SqlCommand com2 = new SqlCommand("select LoginID,username, password,email from tLog where email = @email", con);

            string output = "";
            con.Open();
            com2.Parameters.AddWithValue("@email", textBox2.Text);

            SqlDataReader dr2 = com2.ExecuteReader();
            if (dr2.HasRows == true)
            {
                dr2.Read();
                output = output + dr2.GetValue(0) + "-" + dr2.GetValue(1) + "-" + dr2.GetValue(2) + "-"+ dr2.GetValue(3) + "\n";

                MessageBox.Show(output);
            }
            else
            {
                MessageBox.Show("You input wrong email");
            }

            dr2.Close();
            com2.Dispose();
            con.Close();
        }
    }
    
}

