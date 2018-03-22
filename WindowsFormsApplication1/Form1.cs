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
            int an=number[0];
            //測試
            //label5.Text = textBox1.Text + label1.Text + textBox2.Text + label2.Text + textBox3.Text + label3.Text + textBox4.Text;
            for (int i = 0; i < symbol.Length; i++) {
                if (symbol[i] == button1.Text)
                {
                    an += number[i + 1];
                }
                else if (symbol[i] == button2.Text)
                {
                    an -= number[i + 1];
                }
                else if (symbol[i] == button3.Text)
                {
                    if (i > 0)
                    {
                        if (symbol[i - 1] == button1.Text)
                        {
                            an -= number[i] + number[i] * number[i + 1];
                        }
                        else if (symbol[i - 1] == button2.Text)
                        {
                            an += number[i] - number[i] * number[i + 1];
                        }
                        else {
                            if (symbol[0] == button1.Text)
                            {if(symbol[1]==button3.Text)
                                an = number[0] +number[i - 1] * number[i] * number[i + 1];
                            else
                                    an = number[0] + number[i - 1] /number[i] * number[i + 1];
                            }
                            else if (symbol[0] == button2.Text)
                            {
                                if (symbol[1] == button3.Text)
                                    an = number[0] - number[i - 1] * number[i] * number[i + 1];
                                else
                                    an = number[0] - number[i - 1] / number[i] * number[i + 1];
                            }
                            else
                            {
                                an *= number[i + 1];
                            }
                        }
                    }
                    else
                    {
                        an = number[i] * number[i + 1];
                    }
                }
                else if (symbol[i] == button4.Text) {
                    if (i > 0)
                    {
                        if (symbol[i - 1] == button1.Text)
                        {
                            an -= number[i] + number[i] / number[i + 1];
                        }
                        else if (symbol[i - 1] == button2.Text)
                        {
                            an += number[i] - number[i] / number[i + 1];
                        }
                        else {
                            if (symbol[0] == button1.Text)
                            {if(symbol[1]==button4.Text)
                                an = number[i - 2]+ number[i - 1] / number[i] / number[i + 1];
                            else
                                    an = number[i - 2] +  number[i - 1] * number[i] / number[i + 1];
                            } else if (symbol[0] == button2.Text) {
                                if(symbol[1] == button4.Text)
                                an = number[i - 2] -  number[i - 1] / number[i] / number[i + 1];
                                else
                                    an = number[i - 2] - number[i - 1] * number[i] / number[i + 1];
                            }
                            else {
                                an /= number[i + 1];
                            }
                        }
                    }
                    else
                    {
                        an = number[i] / number[i + 1];
                    }
                }
            }
            label5.Text = ""+an;
        }
    }
}
