namespace WinFormsApp1
{
    public partial class Calculator : Form
    {
        private decimal valueFirst = 0.0m;
        private decimal valueSecond = 0.0m;
        private decimal Result = 0.0m;
        private string operators = "+";
        public Calculator()
        {
            InitializeComponent();
        }



        private void ZeroBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "0";
            }
            else
            {
                TextBox.Text += "0";
            }
        }

        private void DotBtn_Click(object sender, EventArgs e)
        {
            if (!TextBox.Text.Contains("."))
            {
                TextBox.Text += ".";
            }
        }


        private void OneBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "1";
            }
            else
            {
                TextBox.Text += "1";
            }
        }

        private void TwoBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "2";
            }
            else
            {
                TextBox.Text += "2";
            }
        }

        private void ThreeBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "3";
            }
            else
            {
                TextBox.Text += "3";
            }
        }

        private void FourBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "4";
            }
            else
            {
                TextBox.Text += "4";
            }
        }

        private void FiveBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "5";
            }
            else
            {
                TextBox.Text += "5";
            }
        }

        private void SixBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "6";
            }
            else
            {
                TextBox.Text += "6";
            }
        }

        private void SevenBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "7";
            }
            else
            {
                TextBox.Text += "7";
            }
        }

        private void EightBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "8";
            }
            else
            {
                TextBox.Text += "8";
            }
        }

        private void NineBtn_Click(object sender, EventArgs e)
        {
            if (TextBox.Text == "0")
            {
                TextBox.Text = "9";
            }
            else
            {
                TextBox.Text += "9";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextBox.Text.Contains("-"))
            {
                TextBox.Text = TextBox.Text.Trim('-');
            }
            else
            {
                TextBox.Text = "-" + TextBox.Text;
            }
        }

        private void MinusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "-";
        }

        private void PlusBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "+";
        }

        private void DivideBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "/";
        }

        private void MultiplyBtn_Click(object sender, EventArgs e)
        {
            valueFirst = decimal.Parse(TextBox.Text);
            TextBox.Clear();
            operators = "*";
        }

        private void EqualBtn_Click(object sender, EventArgs e)
        {
            switch (operators)
            {
                case "-":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst - valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "+":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst + valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "*":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst * valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
                case "/":
                    valueSecond = decimal.Parse(TextBox.Text);
                    Result = valueFirst / valueSecond;
                    TextBox.Text = Result.ToString();
                    break;
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            valueFirst = 0.0m;
            valueSecond = 0.0m;
            TextBox.Text = "0";
        }
    }
}