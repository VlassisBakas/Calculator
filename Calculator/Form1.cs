using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double value =0;
        string operation = "";
        bool operation_press = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        
        private void Button_Click(object sender, EventArgs e)
        {
           
            if (result.Text == "0") //|| (operation_press))
            {
                result.Clear();
            }
            bool operation_press = false;

            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
        }
        
        private void Button11_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void operatorclick(object sender, EventArgs e)
        {

            Button b = (Button)sender;
          
            operation = b.Text;
            value =Convert.ToDouble(result.Text);
            bool operation_press = true;
            equation.Text = value + "" + operation;
            
        }
       

        private void Button16_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            
            switch (operation)
            {
                case "+":
                    
                    result.Text=(value+ Convert.ToDouble(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Convert.ToDouble(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Convert.ToDouble(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Convert.ToDouble(result.Text)).ToString();
                    break;
                default:
                    break;
            }

            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            result.Text = "0";
            value = 0;
        }

        private void Result_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
