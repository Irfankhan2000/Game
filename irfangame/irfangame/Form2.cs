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
    public partial class Form2 : Form
    {
        int num;
        public Form2()
        {
            InitializeComponent();
        }
        public void checkbutton(Button bt1, Button bt2)
        {
            if (bt2.Text == "")
            {
                bt2.Text = bt1.Text;
                bt1.Text = "";
            }
        
        }

      

        private void button1_Click_1(object sender, EventArgs e)
        {

            checkbutton(button1, button2);
            checkbutton(button1, button5);
            checksolve();
        
        }

        private void button2_Click(object sender, EventArgs e)
        {

            checkbutton(button2, button1);
            checkbutton(button2, button6);
            checkbutton(button2, button3);
            checksolve();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            checkbutton(button4, button3);
            checkbutton(button4, button8);
            checksolve();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkbutton(button3, button2);
            checkbutton(button3, button7);
            checkbutton(button3, button4);
            checksolve();

        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkbutton(button8, button4);
            checkbutton(button8, button7);
            checkbutton(button8, button12);
            checksolve();
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkbutton(button7, button3);
            checkbutton(button7, button6);
            checkbutton(button7, button11);
            checkbutton(button7, button8);
            checksolve();
        }

        private void button6_Click(object sender, EventArgs e)
        {

            checkbutton(button6, button2);
            checkbutton(button6, button5);
            checkbutton(button6, button10);
            checkbutton(button6, button7);
            checksolve();
        }

        private void button5_Click(object sender, EventArgs e)
        {

            checkbutton(button5, button1);
            checkbutton(button5, button6);
            checkbutton(button5, button9);
            checksolve();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            checkbutton(button12, button8);
            checkbutton(button12, button16);
            checkbutton(button12, button11);
            checksolve();
            
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            checkbutton(button11, button7);
            checkbutton(button11, button10);
            checkbutton(button11, button15);
            checkbutton(button11, button12);
            checksolve();
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkbutton(button9, button5);
            checkbutton(button9, button10);
            checkbutton(button9, button13);
            checksolve();
            

        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkbutton(button10, button9);
            checkbutton(button10, button6);
            checkbutton(button10, button11);
            checkbutton(button10, button14);
            checksolve();
            
        }

        private void button16_Click(object sender, EventArgs e)
        {
            checkbutton(button16, button12);
            checkbutton(button16, button15); 
            checksolve();
           
        }

        private void button15_Click(object sender, EventArgs e)
        {
            checkbutton(button15, button11);
            checkbutton(button15, button16);
            checkbutton(button15, button14);
            checksolve();
            
        }

        private void button13_Click(object sender, EventArgs e)
        {
            checkbutton(button13, button9);
            checkbutton(button13, button14);
            checksolve();
            
            
        }

        private void button14_Click(object sender, EventArgs e)
        {
            checkbutton(button14, button10);
            checkbutton(button14, button13);
            checkbutton(button14, button15);
            checksolve();
            
        }
        public void checksolve()
        {
            num = num + 1;
            label1.Text = num + "clicks";
            if(button1.Text=="1"&&button2.Text=="2"&&button3.Text=="3"&&button4.Text=="4"&&button5.Text=="5"&&button6.Text=="6"&&button7.Text=="7"&&button8.Text=="8"&&button9.Text=="9"&&button10.Text=="10"&&button11.Text=="11"&&button12.Text=="12"&&button13.Text=="13"&&button14.Text=="14"&&button15.Text=="15"&&button16.Text=="16")
            {
                MessageBox.Show("you did it in" + num + "Click");
            }
        }
            public void shuffle()
            {
            int i,j,rn;
                int[] a=new int[16];
                Boolean flag =false;
                i=1;
                do
                {

                    Random rnd = new Random();
                    rn = Convert.ToInt32((rnd.Next(0, 15)) + 1);
                    for (j = 1; j <= i; j++)
                    {
                        if (a[j] == rn)
                        {
                            flag = true;
                            break;

                        }
                    }
                    if (flag == true)
                    {
                        flag = false;
                    }
                    else
                    {
                        a[i] = rn;
                        i = i + 1;
                    }
                }
                while (i <= 15);
                button1.Text = Convert.ToString(a[1]);
                button2.Text = Convert.ToString(a[2]);
                button3.Text = Convert.ToString(a[3]);
                button4.Text = Convert.ToString(a[4]);
                button5.Text = Convert.ToString(a[5]);
                button6.Text = Convert.ToString(a[6]);
                button7.Text = Convert.ToString(a[7]);
                button8.Text = Convert.ToString(a[8]);
                button9.Text = Convert.ToString(a[9]);
                button10.Text = Convert.ToString(a[10]);
                button11.Text = Convert.ToString(a[11]);
                button12.Text = Convert.ToString(a[12]);
                button13.Text = Convert.ToString(a[13]);
                button14.Text = Convert.ToString(a[14]);
                button15.Text = Convert.ToString(a[15]);
                button16.Text = "";
                num = 0;
                }

            private void Form2_Load(object sender, EventArgs e)
            {
                shuffle();
            }

            private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
            {

            }

            private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
            {
                shuffle();
            }

            private void exitToolStripMenuItem_Click(object sender, EventArgs e)
            {
                Application.Exit();
            }
               
            
            
            
            
            
        
        
        
        
        
        

                }}

