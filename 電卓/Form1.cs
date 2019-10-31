using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 電卓
{
    public partial class Form1 : Form
    {
        public double input;
        public double Retention=0;
        public string sign="";
        
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

   

        private void textBox1_KeyPress(object sender,
    System.Windows.Forms.KeyPressEventArgs e)
        {
            
            string str = input.ToString();
            if ((e.KeyChar < '0' || '9' < e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '\r' && e.KeyChar != '+' && e.KeyChar != '-' && e.KeyChar != '*' && e.KeyChar != '/')
            {
                //押されたキーが 0～9でない場合は、イベントをキャンセルする
                e.Handled = true;
            }
            else if (input>999999999999)
            {
                e.Handled = true;
            }
            else 
            {
                switch (e.KeyChar)
                {
                    case '0':
                        button0.PerformClick();
                        e.Handled = true;
                        break;
                    case '1':
                        button1.PerformClick();
                        e.Handled = true;
                        break;
                    case '2':
                        button2.PerformClick();
                        e.Handled = true;
                        break;
                    case '3':
                        button3.PerformClick();
                        e.Handled = true;
                        break;
                    case '4':
                        button4.PerformClick();
                        e.Handled = true;
                        break;
                    case '5':
                        button5.PerformClick();
                        e.Handled = true;
                        break;
                    case '6':
                        button6.PerformClick();
                        e.Handled = true;
                        break;
                    case '7':
                        button7.PerformClick();
                        e.Handled = true;
                        break;
                    case '8':
                        button8.PerformClick();
                        e.Handled = true;
                        break;
                    case '9':
                        button9.PerformClick();
                        e.Handled = true;
                        break;
                    case '+':
                        button和.PerformClick();
                        e.Handled = true;
                        break;
                    case '-':
                        button差.PerformClick();
                        e.Handled = true;
                        break;
                    case '*':
                        button積.PerformClick();
                        e.Handled = true;
                        break;
                    case '/':
                        button商.PerformClick();
                        e.Handled = true;
                        break;
                    case '\r':
                        button求.PerformClick();
                        e.Handled = true;
                        break;
                    case '\b':
                        buttonBS.PerformClick();
                        e.Handled = true;
                        break;
                }
            }
            
        }

        public void Calculation(int b)
        {
            if (input > 999999999999)
            {
                return;
            }
            input = input * 10;
            input = input + b;
            textBox1.Text = input.ToString();
        }
        private void buttonBS_Click(object sender, EventArgs e)
        { 
            input = input / 10;
            input = Math.Floor(input);
            textBox1.Text = input.ToString();
        }
        private void buttonC_Click(object sender, EventArgs e)
        {
            input = 0;
            Retention = 0;
            sign = "";
            textBox1.Text = input.ToString();
            label1.Text = sign;
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                input = 0;
                textBox1.Text = input.ToString();
            }
        }
        private void button0_Click(object sender, EventArgs e)
        {
            Calculation(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Calculation(1);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Calculation(2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Calculation(3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Calculation(4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Calculation(5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Calculation(6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Calculation(7);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Calculation(8);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Calculation(9);
        }

        private void button和_Click(object sender, EventArgs e)
        {
            if (sign == "")
            {
                Retention = input;
            }
            else
            {
                switch (sign)
                {
                    case "+":
                        Retention = Retention + input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "-":
                        Retention = Retention - input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "×":
                        Retention = Retention * input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "÷":
                        Retention = Retention / input;
                        textBox1.Text = Retention.ToString();
                        break;
                }
            }
        
            label1.Text = "+";
            input = 0;
            sign = "+";
        }

        private void button差_Click(object sender, EventArgs e)
        {
            if (sign == "")
            {
                Retention = input;
            }
            else
            {
                switch (sign)
                {
                    case "+":
                        Retention = Retention + input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "-":
                        Retention = Retention - input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "×":
                        Retention = Retention * input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "÷":
                        Retention = Retention / input;
                        textBox1.Text = Retention.ToString();
                        break;
                }
            }
            label1.Text = "-";
            input = 0;
            sign = "-";
        }

        private void button積_Click(object sender, EventArgs e)
        {
            if (sign == "")
            {
                Retention = input;
            }
            else
            {
                switch (sign)
                {
                    case "+":
                        Retention = Retention + input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "-":
                        Retention = Retention - input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "×":
                        Retention = Retention * input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "÷":
                        Retention = Retention / input;
                        textBox1.Text = Retention.ToString();
                        break;
                }
            }
            label1.Text = "×";
            input = 0;
            sign = "×";
        }

        private void button商_Click(object sender, EventArgs e)
        {
            if (sign == "")
            {
                Retention = input;
            }
            else
            {
                switch (sign)
                {
                    case "+":
                        Retention = Retention + input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "-":
                        Retention = Retention - input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "×":
                        Retention = Retention * input;
                        textBox1.Text = Retention.ToString();
                        break;
                    case "÷":
                        Retention = Retention / input;
                        textBox1.Text = Retention.ToString();
                        break;
                }
            }
            label1.Text = "÷";
            input = 0;
            sign = "÷";
        }

        private void button求_Click(object sender, EventArgs e)
        {
            switch (sign)
            {
                case "+":
                    Retention = Retention + input;
                    textBox1.Text = Retention.ToString();
                    break;
                case "-":
                    Retention = Retention - input;
                    textBox1.Text = Retention.ToString();
                    break;
                case "×":
                    Retention = Retention * input;
                    textBox1.Text = Retention.ToString();
                    break;
                case "÷":
                    Retention = Retention / input;
                    textBox1.Text = Retention.ToString();
                    break;
            }
        }

        private void buttonCE_Click(object sender, EventArgs e)
        {
            input = 0;
            textBox1.Text = input.ToString();
        }
    }
}
