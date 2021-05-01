using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a
{
    public partial class Form1 : Form
    {
        String s = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            s = "";
            s = textBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n,i,flag=0;
            n = Convert.ToInt32(s);
            for (i = 2; i <= n / 2; ++i)
            {

             
                if (n % i == 0)
                {
                    flag = 1;
                    break;
                }
            }

            if (n == 1)
            {
                textBox2.Text = "yes";
            }
            else
            {
                if (flag == 0)
                    textBox2.Text = "Yes";
                else
                    textBox2.Text = "No";
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox3.Text = "";
            int s1 = Convert.ToInt32(s);
            int k = s1;
            int sum = 0;
            for (int i = 1; i < s1; i++)
            {
                if (s1 % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == s1)
            {
                textBox3.Text = "Yes";
            }
            else
            {
                textBox3.Text = "No";
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(s);
            int k = s1;
            int sum = 0;
            while (k >= 1)
            {
                sum = sum + (k % 10) * (k % 10) * (k % 10);
                k = k / 10;
            }
            if (sum == s1)
            {
                textBox4.Text = "Yes";
            }
            else
            {
                textBox4.Text = "No";
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int s1 = Convert.ToInt32(s);
            int k = s1;
            int sum = 0;
            for (int i = 1; i < s1; i++)
            {
                if (s1 % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == s1)
            {
                textBox3.Text = "Yes";
            }
            else
            {
                textBox3.Text = "No";
            }
            s1 = Convert.ToInt32(s);
            k = s1;
            sum = 0;
            while (k >= 1)
            {
                sum = sum + (k % 10) * (k % 10) * (k % 10);
                k = k / 10;
            }
            if (sum == s1)
            {
                textBox4.Text = "Yes";
            }
            else
            {
                textBox4.Text = "No";
            }
            s1 = Convert.ToInt32(s);
            int ca = 0;
            for (int i = 1; i < s1; i++)
            {
                if (s1 % i == 0)
                {
                    ca = ca + 1;
                }
                if (ca > 1)
                {
                    break;
                }
            }
            if (ca == 1)
            {
                textBox2.Text = "Yes";
            }
            else
            {
                textBox2.Text = "No";
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
   
