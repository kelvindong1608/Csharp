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


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {   try
            {
                SqlConnection con = new SqlConnection (@"server= KELVIN\SQLEXPRESS;database= Login;Integrated Security =true");
                SqlCommand com = new SqlCommand("SELECT * FROM tLog where username =@user and password =@pw", con);
                con.Open();
                com.Parameters.AddWithValue("@user", textBox1.Text);
                com.Parameters.AddWithValue("@pw", textBox2.Text);
                SqlDataReader dr = com.ExecuteReader();
                if (dr.HasRows == true)

                {
                    MessageBox.Show("Corrected!");
                }
                else
                {
                    MessageBox.Show("Check your info carefully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            /*  bool check = checkBox1.Checked;
              switch (check)
              {
                  case true:
                      textBox2.UseSystemPasswordChar = false;break;
                  default:
                      textBox2.UseSystemPasswordChar = true;break;
                     } */
            if (checkBox1.Checked == true)
                textBox2.UseSystemPasswordChar = false;
            else
                textBox2.UseSystemPasswordChar = true;



            
        }
    }
}
