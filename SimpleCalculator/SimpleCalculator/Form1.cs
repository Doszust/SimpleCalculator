//Author Dylan Oszust
//June 17, 2018


using System;
using System.Windows.Forms;

namespace SimpleCalculator
{
    public partial class Calculator : Form
    {

        private bool Decimal = false; //Tracks Decimal Entry
        private bool Operation = false; //Tracks Operation Entry
        private double num1 = 0; //First Number Entered
        private double num2 = 0; //Second Number Entered
        private double numSolution = 0; //Solution to be displayed
        private char math; //Tracks Mathmatical Operation

        public Calculator()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonTableLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "0"; //adds 0 to end of display
        }

        private void btnNum1_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "1"; //adds 1 to end of display
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "2"; //adds 2 to end of display
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "3"; //adds 3 to end of display
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "4"; //adds 4 to end of display
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "5"; //adds 5 to end of display
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "6"; //adds 6 to end of display
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "7"; //adds 7 to end of display
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "8"; //adds 8 to end of display
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            lblDisplay.Text += "9"; //adds 9 to end of display
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!Operation)
            {
                num1 = Double.Parse(lblDisplay.Text); //saves number entered to num1
                lblDisplay.ResetText(); //clears screen
                math = '+'; //set for addition
            }

            Operation = true; //operation has been entered
            Decimal = false; //allows decimal to be placed again
        }        

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            if (!Operation)
            {
                num1 = Double.Parse(lblDisplay.Text);
                lblDisplay.ResetText();
                math = '-'; //set for subtraction
            }

            Operation = true;
            Decimal = false;
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            if (!Operation)
            {
                num1 = Double.Parse(lblDisplay.Text);
                lblDisplay.ResetText();
                math = '/'; //set for division
            }

            Operation = true;
            Decimal = false;
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            if (!Operation)
            {
                num1 = Double.Parse(lblDisplay.Text);
                lblDisplay.ResetText();
                math = '*'; //set for multiplication
            }

            Operation = true;
            Decimal = false;
            
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (Operation)
            {
                num2 = Double.Parse(lblDisplay.Text); //saves second entry to num2

                switch (math) //performs operation based on math button pressed
                {
                    case '+':
                        numSolution = num1 + num2;
                        break;
                    case '-':
                        numSolution = num1 - num2;
                        break;
                    case '*':
                        numSolution = num1 * num2;
                        break;
                    case '/':
                        numSolution = num1 / num2;
                        break;
                }
                lblDisplay.Text = numSolution.ToString(); //displays solution
                num1 = numSolution; //sets solution to num1 for further calculations
                Operation = false; //allows another calculation
            }
        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            if (!Decimal) //no decimal has been placed yet (only allows for one decimal per number)
            {
                lblDisplay.Text += ".";
            }
            Decimal = true; //decimal has been placed
        }

        private void lblDisplay_Click(object sender, EventArgs e)
        {

        }
    }
}
