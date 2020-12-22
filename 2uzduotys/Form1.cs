using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2uzduotys
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            int sum = 0;
            

            string test = textBox1.Text;
            var numbers = test.Split(' ');
            int[] num2 = new int[10];
            for(int i = 0; i < numbers.Length; i++)
            {
                    num2[i] = Convert.ToInt32(numbers[i]);
                    sum += num2[i];
            }

            if (numbers.Length != 10)
            {
                label1.Visible = true;
                label1.Text = "Per mazai masyvo elementu";
            }

            

            //label1.Text = Convert.ToString(numbers.Length);
             textBox2.Text = Convert.ToString(sum);
        }


        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
