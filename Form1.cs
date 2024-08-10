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

        enum Operators
        { 
            None,
            Add,
            Subtract,
            Multiply,
            Divide,
            Result
        }

        Operators currentOperator = Operators.None;
        Boolean operatorChangeFlag = false;
        int firstOperand = 0;
        int secondOperand = 0;


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e) // = 버튼
        {
            secondOperand = Int32.Parse(display.Text);
            if (currentOperator == Operators.Add)
            {
                firstOperand += secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Subtract)
            {
                firstOperand -= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Multiply)
            {
                firstOperand *= secondOperand;
                display.Text = firstOperand.ToString();
            }
            else if (currentOperator == Operators.Divide)
            {
                if (secondOperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다";
                }
                else
                {
                    firstOperand /= secondOperand;
                    display.Text = firstOperand.ToString();
                }
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e) // AC초기화 버튼
        {
            firstOperand = 0;
            secondOperand = 0;
            currentOperator = Operators.None;
            display.Text = "0";
        }


        private void ButtonAdd_Click(object sender, EventArgs e) // + 버튼
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator= Operators.Add;
            operatorChangeFlag = true;
        }
        private void ButtonSubtract_Click(object sender, EventArgs e) // - 버튼
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator= Operators.Subtract;
            operatorChangeFlag = true;

        }

        private void ButtonMultiply_Click(object sender, EventArgs e) // * 버튼
        {
            firstOperand= Int32.Parse(display.Text);
            currentOperator= Operators.Multiply;
            operatorChangeFlag = true;
        }

        private void ButtonDivide_Click(object sender, EventArgs e) // 나누기 버튼
        {
            firstOperand = Int32.Parse(display.Text);
            currentOperator= Operators.Divide;
            operatorChangeFlag = true;
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonZero_Click(object sender, EventArgs e) // 0 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "0";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();

        }





        private void ButtonOne_Click(object sender, EventArgs e) // 1 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "1";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonTwo_Click(object sender, EventArgs e) // 2 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "2";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonThree_Click(object sender, EventArgs e) // 3 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "3";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFour_Click(object sender, EventArgs e) // 4 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "4";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonFive_Click(object sender, EventArgs e) //5 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "5";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonSix_Click(object sender, EventArgs e) // 6 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "6";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }


        private void ButtonSeven_Click(object sender, EventArgs e) // 7 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "7";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonEight_Click(object sender, EventArgs e) // 8 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "8";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

        private void ButtonNine_Click(object sender, EventArgs e) // 9 버튼
        {
            if (operatorChangeFlag == true)
            {

                display.Text = "";
                operatorChangeFlag = false;
            }

            string strNumber = display.Text += "9";
            int intNumber = Int32.Parse(strNumber);
            display.Text = intNumber.ToString();
        }

  

     
    

    }
}
