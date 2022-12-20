using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CalculatorPrj
{
    public partial class Form1 : Form
    {
     //testing
        public Form1()
        {
            InitializeComponent();
        }
        
        float ans,perans = 0; 
        
        List<float> number = new List<float>();
        List<string> op = new List<string>();

        private void checkZero()
        {
            if (txtOutput.Text != "" && float.Parse(txtOutput.Text) == 0)
            {
                txtOutput.Text = "";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + 0;
        }
        private void btn00_Click(object sender, EventArgs e)
        {
            checkZero();
            txtOutput.Text = txtOutput.Text + "00";
        }
        private void btnPlus_Click(object sender, EventArgs e)
        {
            number.Add(float.Parse(txtOutput.Text)); //Add number List array[0]  
            op.Add("+"); //Add operation
            txtOutput.Clear();
            txtOutput.Focus();
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            number.Add(float.Parse(txtOutput.Text));
            op.Add("-");
            txtOutput.Clear();
            txtOutput.Focus();

        }

        private void btnMulti_Click(object sender, EventArgs e)
        {
            number.Add(float.Parse(txtOutput.Text));
            op.Add("x");
            txtOutput.Clear();
            txtOutput.Focus();
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            number.Add(float.Parse(txtOutput.Text));
            op.Add("÷");
            txtOutput.Clear();
            txtOutput.Focus();
        }
        private void button11_Click(object sender, EventArgs e)
        {
            float percent = float.Parse(txtOutput.Text); 
            

            if (number.Count == 1)
            {
                percent = number[0] * (percent / 100);
               
            } 
            else if (number.Count > 1) {
                
                perans = number[0];
                for (int i = 0; i < (op.Count-1); i++)
                {

                    switch (op[i])
                    {
                        case "+":
                            perans += number[i + 1];
                            break;
                        case "-":
                            perans -= number[i + 1];
                            break;
                        case "x":
                            perans *= number[i + 1];
                            break;
                        case "÷":
                            perans = ans / number[i + 1];
                            break;

                    }
                }
                percent = perans * (percent / 100);
               
            }

            else 
            {
                percent = percent / 100;
               
            }

            txtOutput.Text = Convert.ToString(percent);

        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            int d = txtOutput.TextLength; //For point
            int point = 0;
            string text = txtOutput.Text;
            for (int i = 0; i < d; i++)
            {
                if (text[i].ToString() == ".")
                {
                    point = 1;
                    break;
                }
                else
                {
                    point = 0;
                }
            }
            if (point == 0)
            {
                txtOutput.Text = txtOutput.Text + ".";
            }
        }

        private void btnEqual_Click(object sender, EventArgs e)
        { 
            number.Add(float.Parse(txtOutput.Text)); 
            compute();
            txtOutput.Text = ans.ToString();           
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            string delete = "";
            if (txtOutput.Text.Length > 1)
            {
                delete = txtOutput.Text;
                delete = delete.Substring(0, delete.Length - 1);
            }
            txtOutput.Text = delete;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            ans = 0;
            perans = 0;
            number = new List<float>();
            op = new List<string>();
            
        }

   
        public float compute()
        {
            ans = number[0];
            for (int i = 0; i < op.Count; i++)
            {

                switch (op[i])
                {
                    case "+":
                        ans += number[i + 1];
                        break;
                    case "-":
                        ans -= number[i + 1];
                        break;
                    case "x":
                        ans *= number[i + 1];
                        break;
                    case "÷":
                        ans = ans / number[i + 1];
                        break;

                }
            }
            number.Clear();
            op.Clear();
            return ans;
        }

      
    }
}
