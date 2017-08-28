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
        public Form1()
        {
            InitializeComponent();
            this.lable1 = new Label();
            this.textBox1 = new TextBox();
            this.button1 = new Button();

            this.SuspendLayout();

            this.lable1.Location = new System.Drawing.Point(16, 36);
            this.lable1.Name = "label1";
            this.lable1.Size = new System.Drawing.Size(128, 16);
            this.lable1.TabIndex = 0;
            this.lable1.Text = "Pls enter your name:";

            this.textBox1.Location = new System.Drawing.Point(152, 32);
            this.textBox1.Name = "textbox1";
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = "";

            this.button1.Location = new System.Drawing.Point(109, 80);
            this.button1.Name = "button1";
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.Click += new System.EventHandler(this.button1_Click);

            this.ClientSize = new System.Drawing.Size(292, 126);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lable1);
            this.Name = "form1";
            this.Text = "New Zealand";

            this.ResumeLayout(false);
        }
        public static void Main1()
        {
            Application.Run(new Form1());
        }
        private void button1_Click(object sender, System.EventArgs e)
        {
            System.Console.WriteLine(" User entered:" + textBox1.Text);
            MessageBox.Show("Welcome to New Zealand2," + textBox1.Text, "Welcome to New Zealand2");
            Application.Exit();
        }





    }
}
