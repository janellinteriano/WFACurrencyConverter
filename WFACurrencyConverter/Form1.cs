using System.Collections.ObjectModel;

namespace WFACurrencyConverter
{
    public partial class Form1 : Form
    {
        public string userInput { get; set; }
        public int currSelected { get; set; }

        public Form1()
        {
            InitializeComponent();
        }
        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            userInput = textBox1.Text;
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            currSelected = comboBox1.SelectedIndex;
        }

        public void button1_Click(object sender, EventArgs e)
        {


            double result;
            string currName;
            if (currSelected == ((int)CurrEnum.EUR))
            {
                result = double.Parse(userInput) * 0.941023;
            }
            else if (currSelected == ((int)CurrEnum.JPY))
            {
                result = double.Parse(userInput) * 154.224;
            }
            else if (currSelected == ((int)CurrEnum.CAD))
            {
                result = double.Parse(userInput) * 1.37833;
            }
            else if (currSelected == ((int)CurrEnum.AUD))
            {
                result = double.Parse(userInput) * 1.55186;
            }
            else if (currSelected == ((int)CurrEnum.SGD))
            {
                result = double.Parse(userInput) * 1.36265;
            }
            else if (currSelected == ((int)CurrEnum.INR))
            {
                result = double.Parse(userInput) * 83.5024;

            }
            else
            {
                result = 0.00;
            }

            newAmt.Text = DisplayNewAmount(result, currSelected);
        }


        public static string DisplayNewAmount(double intResult, int currSelected)
        {
            

            if (intResult > 0)
            {
                string newResult;
                if (currSelected == (int)CurrEnum.EUR)
                {
                    newResult = $"€{Math.Round(intResult, 2)}";
                    return newResult;
                }
                else if (currSelected == (int)CurrEnum.JPY)
                {
                    newResult = $"¥{Math.Round(intResult, 2)}";
                    return newResult;
                }
                else if (currSelected == (int)CurrEnum.CAD)
                {
                    newResult = $"${Math.Round(intResult, 2)}";
                    return newResult;
                }
                else if (currSelected == (int)CurrEnum.AUD)
                {
                    newResult = $"${Math.Round(intResult, 2)}";
                    return newResult;
                }
                else if (currSelected == (int)CurrEnum.SGD)
                {
                    newResult = $"${Math.Round(intResult, 2)}";
                    return newResult;
                }
                else if (currSelected == (int)CurrEnum.INR)
                {
                    newResult = $"₹{Math.Round(intResult, 2)}";
                    return newResult;
                }
                else
                {
                    newResult = "0.00";
                    return newResult;
                }
            }
            return string.Empty;
        }
    }
}