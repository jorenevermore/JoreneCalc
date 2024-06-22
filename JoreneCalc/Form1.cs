using System;
using System.Windows.Forms;

namespace JoreneCalc
{
    public partial class Form1 : Form
    {
        private string input = string.Empty;        // String storing user input
        private string operand1 = string.Empty;     // String storing first operand
        private string operand2 = string.Empty;     // String storing second operand
        private char operation;                     // Char representing the operation
        private double result = 0.0;                // Calculated result

        public Form1()
        {
            InitializeComponent();
        }

        private void btnNumOne_Click(object sender, EventArgs e)
        {
            AppendToInput("1");
        }

        private void btnNumTwo_Click(object sender, EventArgs e)
        {
            AppendToInput("2");
        }

        private void btnNumThree_Click(object sender, EventArgs e)
        {
            AppendToInput("3");
        }

        private void btnNumFour_Click(object sender, EventArgs e)
        {
            AppendToInput("4");
        }

        private void btnNumFive_Click(object sender, EventArgs e)
        {
            AppendToInput("5");
        }

        private void btnNumSix_Click(object sender, EventArgs e)
        {
            AppendToInput("6");
        }

        private void btnNumSeven_Click(object sender, EventArgs e)
        {
            AppendToInput("7");
        }

        private void btnNumEight_Click(object sender, EventArgs e)
        {
            AppendToInput("8");
        }

        private void btnNumNine_Click(object sender, EventArgs e)
        {
            AppendToInput("9");
        }

        private void btnNumZero_Click(object sender, EventArgs e)
        {
            AppendToInput("0");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperator('+');
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            SetOperator('-');
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            SetOperator('*');
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            SetOperator('/');
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            numDisplay.Clear();
            resultDisplay.Text = "";
            input = string.Empty;
        }

        private void AppendToInput(string value)
        {
            input += value;
            numDisplay.Text = input;
        }

        private void SetOperator(char op)
        {
            if (!string.IsNullOrEmpty(input) &&
                (Char.IsDigit(input[input.Length - 1]) || input.EndsWith(".")))
            {
                input += " " + op + " ";
                numDisplay.Text = input;
            }
        }

        private void btnEquals_Click_1(object sender, EventArgs e)
        {
            try
            {
                var dataTable = new System.Data.DataTable();
                var resultObj = dataTable.Compute(input, string.Empty);
                var result = Convert.ToDouble(resultObj);
                resultDisplay.Text = result.ToString();
                input = result.ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid operation");
                input = string.Empty;
                numDisplay.Text = string.Empty;
                resultDisplay.Text = string.Empty;
            }
        }

        private void btnPoint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input) || !input.EndsWith("."))
            {
                AppendToInput(".");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void resultDisplay_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
