using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.label1.Text = "User name";
            this.label2.Text = "Password";
           
            this.button1.Text = "OK";
            this.BackColor = Color.AntiqueWhite;
            this.AcceptButton = button1;
            

        }

        

    

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Admin" && textBox2.Text == "123")
            {
                Form2 a = new Form2();
                a.Show();

            }
            else
            {
                MessageBox.Show("User name or Password is incorrect");
            }
        }
    }
}
