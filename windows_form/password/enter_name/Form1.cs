using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enter_name
{
    public partial class Form1 : Form
    {
        private Label lable1;
        private TextBox textBox1;
        private Button button1;
        private TextBox textBox2;
        private Label label2;
        private Button button2;
        public Form1()
        {
            InitializeComponent();
            this.lable1 = new Label();
            this.textBox1 = new TextBox();
            this.textBox2 = new TextBox();
            this.button1 = new Button();
            this.label2 = new Label();
            this.button2 = new Button();

            this.SuspendLayout();

            this.lable1.Location = new System.Drawing.Point(16, 12);
            this.lable1.Name = "label1";
            this.lable1.Size = new System.Drawing.Size(128, 16);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Pls enter your username:";

            this.textBox1.Location = new System.Drawing.Point(152, 12);
            this.textBox1.Name = "textbox1";
            this.textBox1.TabIndex = 2;
            this.textBox1.Text = "";

            this.textBox2.Location = new System.Drawing.Point(152, 44);
            this.textBox2.Name = "textbox2";
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "";

            this.label2.Location = new System.Drawing.Point(16, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pls enter your pass:";

            this.button1.Location = new System.Drawing.Point(109, 80);
            this.button1.Name = "button1";
            this.button1.TabIndex = 4;
            this.button1.Text = "Enter";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.button2.Location = new System.Drawing.Point(210, 80);
            this.button2.Name = "button2";
            this.button2.TabIndex = 5;
            this.button2.Text = "Exit";
            this.button2.Click += new System.EventHandler(this.button1_Click2);

            this.ClientSize = new System.Drawing.Size(400, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "form1";
            this.Text = "username: kelvin , pass : 123";

            this.ResumeLayout(false);
        }
        public static void Main1()
        {
            Application.Run(new Form1());
        }
        private void button1_Click(object sender, System.EventArgs e)
        {   if (this.textBox1.Text == "kelvin")
            {
                if (this.textBox2.Text == "123")
                    MessageBox.Show("you has sucessfully signed in");
            }
            else
                MessageBox.Show("pls input your data again");          


       
        }

        private void button1_Click2(object sender, System.EventArgs e)
        {
            DialogResult i;
            i = MessageBox.Show(" Are you sure ?", " Warning",MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk);
            if (i==DialogResult.Yes)
                Application.Exit();
        }



    }
}
