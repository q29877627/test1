using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        int time = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (time)
            {
                case 0:
                    label1.Text = button1.Text;
                    time++;
                    break;
                case 1:
                    label2.Text = button1.Text;
                    time++;
                    break;
                case 2:
                    label3.Text = button1.Text;
                    time++;
                    break;

            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //djflasjdlfjasldjflasjf
            //測試
        }

        private void button3_Click(object sender, EventArgs e)
        {
            switch (time)
            {
                case 0:
                    label1.Text = button3.Text;
                    time++;
                    break;
                case 1:
                    label2.Text = button3.Text;
                    time++;
                    break;
                case 2:
                    label3.Text = button3.Text;
                    time++;
                    break;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            switch (time)
            {
                case 0:
                    label1.Text = button2.Text;
                    time++;
                    break;
                case 1:
                    label2.Text = button2.Text;
                    time++;
                    break;
                case 2:
                    label3.Text = button2.Text;
                    time++;
                    break;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            switch (time)
            {
                case 0:
                    label1.Text = button4.Text;
                    time++;
                    break;
                case 1:
                    label2.Text = button4.Text;
                    time++;
                    break;
                case 2:
                    label3.Text = button4.Text;
                    time++;
                    break;

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] symbol = {label1.Text,label2.Text,label3.Text};
            int[] number = { int.Parse(textBox1.Text), int.Parse(textBox2.Text),int.Parse(textBox3.Text), int.Parse(textBox4.Text) };
            //測試
            //label5.Text = textBox1.Text + label1.Text + textBox2.Text + label2.Text + textBox3.Text + label3.Text + textBox4.Text;
            for (int i = 0; i < symbol.Length; i++) {
                
            }


        }
    }
}
