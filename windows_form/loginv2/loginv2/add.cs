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
    public partial class add : Form
    {
        public add()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"server= KELVIN\SQLEXPRESS; database = Login; Integrated Security =true");
            SqlCommand com = new SqlCommand("Insert into Empinfo values( @id,@fname,@lname,@dob,@phone,@add)", con);
            con.Open();
                com.Parameters.AddWithValue("@id", textBox1.Text);
                com.Parameters.AddWithValue("@fname", textBox2.Text);
                com.Parameters.AddWithValue("@lname", textBox3.Text);
                com.Parameters.AddWithValue("@dob", textBox4.Text);
                com.Parameters.AddWithValue("@phone", textBox5.Text);
                com.Parameters.AddWithValue("@add", textBox6.Text);
                
                SqlDataReader dr = com.ExecuteReader();
                MessageBox.Show("Data has been saved");
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
            textBox6.Text = string.Empty;


            /* catch ( Exception ex)
             {
                 MessageBox.Show(ex.Message);
             }*/
        }
    }
}
