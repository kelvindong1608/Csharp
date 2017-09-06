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

namespace loginv2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //int i=0;
            string x;
            SqlConnection con = new SqlConnection(@"server= KELVIN\SQLEXPRESS;database= Login; Integrated Security=true");
            SqlCommand com;
            con.Open();
            if (comboBox1.Text== "Username")
            {
                x = "select username, password from tLog where username =@user and password =@pass";
                
            }
            else
            {
                x = "select email, password from tLog where email =@email and password =@pass";
            }
            com = new SqlCommand(x,con);
            if (comboBox1.Text == "Username")
            {
                com.Parameters.AddWithValue("@user", textBox1.Text);
                com.Parameters.AddWithValue("@pass", textBox2.Text);
            }
            else
            {
                com.Parameters.AddWithValue("@email", textBox1.Text);
                com.Parameters.AddWithValue("@pass", textBox2.Text);
            }
            
            SqlDataReader dr = com.ExecuteReader();
           /* while (dr.Read())
            {
                i = i + 1;
            }
           // if (i == 1)
           / {*/
                if (dr.HasRows == true)

                {
                    MessageBox.Show("you are connected successfully");
                this.Hide();
                Form2 f2 = new Form2();
                f2.ShowDialog();

                }

                else
                {

                    MessageBox.Show("you inputed your info wrongly");
                }
          /*  }
            else 
            {
                MessageBox.Show("Duplicate user info. Access denied!!");
            }*/
            dr.Close();
            com.Dispose();
            con.Close();
        }

     

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == false)
                textBox2.UseSystemPasswordChar = true;
            else
                textBox2.UseSystemPasswordChar = false;
        }

        private void button2_Click(object sender, EventArgs e)
        { DialogResult i;
            i = MessageBox.Show("Are You Sure", "warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(i==DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
