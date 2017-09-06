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

        
           

            
         

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server = KELVIN\SQLEXPRESS;database= Login;Integrated Security =true");      
            

            string ctext,output;
            SqlCommand com;            
            con.Open();

            if (comboBox1.Text == "Username")
            {
                ctext = ("select LoginID,username, password,email from tLog where username = @user");
                

            }
            else
            {
                ctext = ("select LoginID, username, password, email from tLog where email = @email");
                
            }

            com = new SqlCommand(ctext, con);


            if (comboBox1.Text == "Username")
            {
                com.Parameters.AddWithValue("@user", textBox1.Text);

            }
            else
            {
                com.Parameters.AddWithValue("@email", textBox1.Text);

            }                    

            SqlDataReader dr = com.ExecuteReader();

            result.Items.Clear();
            if (dr.HasRows == true)
            {   
                dr.Read();


                output = "your ID: " + dr.GetValue(0) + "\n"
                    + "your username: " +dr.GetValue(1) +"\n"
                    + "your password" + dr.GetValue(2) + "\n" 
                    + "your email" + dr.GetValue(3) + "\n";

                foreach (string line in output.Split('\n'))
                    result.Items.Add(line);
              
                
            }
            else
            {
                result.Items.Add ( "You input wrong email");
                
            }
           
            dr.Close();
            com.Dispose();
            con.Close();
        }

        private void result_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}

