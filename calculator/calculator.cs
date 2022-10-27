using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class calculator : Form
    {
        public calculator()
        {
            InitializeComponent();
        }

        private void calculator_Load(object sender, EventArgs e)
        {
            txtDisplay.Focus();

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button18_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);
            Addition = true;
            Subtraction = false;
            multiplication = false;
            Division = false;
            txtDisplay.Clear();
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnOne.Text;
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnThree.Text;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnZero.Text;
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);

            Addition = false;
            Subtraction = false;
            multiplication = false;
            Division = true;
            txtDisplay.Clear();
       
        }

        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);

            Addition = false;
            Subtraction = false;
            multiplication = true;
            Division = false;
            txtDisplay.Clear();
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = txtDisplay.Text.Remove(txtDisplay.Text.Length - 1);

        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSeven.Text;
        }
        double num1, num2, Answer;
        bool Addition = false;
        bool Subtraction = false;
        bool multiplication = false;
        bool Division = false;
        private void btnEqual_Click(object sender, EventArgs e)
        {
            


            if (Addition)
            {
               
                num2 = double.Parse(txtDisplay.Text);
                Answer = num1 + num2;
                txtDisplay.Text = Answer.ToString();
            } 
            else if(multiplication)
            {
              
                num2 = double.Parse(txtDisplay.Text);
                Answer = num1 * num2;
                txtDisplay.Text = Answer.ToString();
            }

            else if(Subtraction)

            {

                num2 = double.Parse(txtDisplay.Text);
                Answer = num1 - num2;
                txtDisplay.Text = Answer.ToString();
            }
            else if (Division)
            {

                num2 = double.Parse(txtDisplay.Text);
                Answer = num1 / num2;
                txtDisplay.Text = Answer.ToString();
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnPoint.Text;
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFour.Text;
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnEight.Text;
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnTwo.Text;
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnNine.Text;
        }
        double ans = 1, num;
        int i;
        private void btnFactorial_Click(object sender, EventArgs e)
        {
            num = double.Parse(txtDisplay.Text);
            for (i = 1; i <= num; i++)
            {
                // ans *=i 
                ans = ans * i;


            }

            txtDisplay.Text = ans.ToString();
            ans = 1;    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Clear();
            txtDisplay.Focus();
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            num1 = double.Parse(txtDisplay.Text);

            Addition = false;
            Subtraction = true;
            multiplication = false;
            Division = false;
            txtDisplay.Clear();
            

        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnFive.Text;
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSix.Text;
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About abt = new About();
            abt.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
