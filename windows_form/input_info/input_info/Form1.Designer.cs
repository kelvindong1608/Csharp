namespace input_info
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tName = new System.Windows.Forms.TextBox();
            this.tAdd = new System.Windows.Forms.TextBox();
            this.lcity = new System.IO.FileSystemWatcher();
            this.rMale = new System.Windows.Forms.RadioButton();
            this.rFemal = new System.Windows.Forms.RadioButton();
            this.cb1 = new System.Windows.Forms.CheckBox();
            this.cb2 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ladd = new System.Windows.Forms.ListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "HELLO WORLD";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tAdd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(242, 100);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "USER DETAILS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NAME :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ADDRESS :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // tName
            // 
            this.tName.Location = new System.Drawing.Point(127, 23);
            this.tName.Name = "tName";
            this.tName.Size = new System.Drawing.Size(100, 22);
            this.tName.TabIndex = 3;
            // 
            // tAdd
            // 
            this.tAdd.Location = new System.Drawing.Point(127, 54);
            this.tAdd.Name = "tAdd";
            this.tAdd.Size = new System.Drawing.Size(100, 22);
            this.tAdd.TabIndex = 4;
            // 
            // lcity
            // 
            this.lcity.EnableRaisingEvents = true;
            this.lcity.SynchronizingObject = this;
            // 
            // rMale
            // 
            this.rMale.AutoSize = true;
            this.rMale.Location = new System.Drawing.Point(285, 105);
            this.rMale.Name = "rMale";
            this.rMale.Size = new System.Drawing.Size(59, 21);
            this.rMale.TabIndex = 3;
            this.rMale.TabStop = true;
            this.rMale.Text = "Male";
            this.rMale.UseVisualStyleBackColor = true;
            this.rMale.CheckedChanged += new System.EventHandler(this.rMale_CheckedChanged);
            // 
            // rFemal
            // 
            this.rFemal.AutoSize = true;
            this.rFemal.Location = new System.Drawing.Point(285, 139);
            this.rFemal.Name = "rFemal";
            this.rFemal.Size = new System.Drawing.Size(75, 21);
            this.rFemal.TabIndex = 4;
            this.rFemal.TabStop = true;
            this.rFemal.Text = "Female";
            this.rFemal.UseVisualStyleBackColor = true;
            this.rFemal.CheckedChanged += new System.EventHandler(this.rFemal_CheckedChanged);
            // 
            // cb1
            // 
            this.cb1.AutoSize = true;
            this.cb1.Location = new System.Drawing.Point(285, 215);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(94, 21);
            this.cb1.TabIndex = 5;
            this.cb1.Text = "Long Stay";
            this.cb1.UseVisualStyleBackColor = true;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // cb2
            // 
            this.cb2.AutoSize = true;
            this.cb2.Location = new System.Drawing.Point(285, 255);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(135, 21);
            this.cb2.TabIndex = 6;
            this.cb2.Text = "Live with Partner";
            this.cb2.UseVisualStyleBackColor = true;
            this.cb2.CheckedChanged += new System.EventHandler(this.cb2_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(155, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ladd
            // 
            this.ladd.FormattingEnabled = true;
            this.ladd.ItemHeight = 16;
            this.ladd.Items.AddRange(new object[] {
            "Mumbai",
            "Ho Chi Minh",
            "Auckland"});
            this.ladd.Location = new System.Drawing.Point(9, 215);
            this.ladd.Name = "ladd";
            this.ladd.Size = new System.Drawing.Size(120, 84);
            this.ladd.TabIndex = 8;
            this.ladd.SelectedIndexChanged += new System.EventHandler(this.ladd_SelectedIndexChanged_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(248, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 74);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(285, 315);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Exit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 350);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.ladd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb2);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.rFemal);
            this.Controls.Add(this.rMale);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lcity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tAdd;
        private System.Windows.Forms.TextBox tName;
        private System.IO.FileSystemWatcher lcity;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb2;
        private System.Windows.Forms.CheckBox cb1;
        private System.Windows.Forms.RadioButton rFemal;
        private System.Windows.Forms.RadioButton rMale;
        private System.Windows.Forms.ListBox ladd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}

