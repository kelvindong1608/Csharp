using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace input_info
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void label3_Click(object sender, EventArgs e)
        {
         
        }

        private void ladd_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void ladd_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string te = ladd.GetItemText(ladd.SelectedItem);
            MessageBox.Show(te);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = tName.Text;
            String add = tAdd.Text;
            if (name == "" || add == "")
                MessageBox.Show("Pls input your name and add correctly");
            else
                MessageBox.Show("Your name :" +name + "\n" + "Your add:"+ add);
            



        }

        private void rMale_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult i;
            i = MessageBox.Show(" are you sure!!!", "haha", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            if (i == DialogResult.OK)
                MessageBox.Show("you are male");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult i;
           i= MessageBox.Show(" Are you sure", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (i == DialogResult.Yes)
                Application.Exit();
        }

        private void rFemal_CheckedChanged(object sender, EventArgs e)
        {
            DialogResult i;
            i = MessageBox.Show(" are you sure!!!", "haha", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            if (i== DialogResult.OK)
            MessageBox.Show("you are female");
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Then I will get more money from you hehe");
        }

        private void cb2_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Enjoy your wondeful moments");
        }
    }
}
