namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowInputError(string message)
        {
            lblResult.Text = "Result:";
            MessageBox.Show(message, "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private bool ReadTwoNumbers(out double firstNumber, out double secondNumber)
        {
            bool firstValid = double.TryParse(txtNumber1.Text, out firstNumber);
            bool secondValid = double.TryParse(txtNumber2.Text, out secondNumber);

            if (!firstValid || !secondValid || !double.IsFinite(firstNumber) || !double.IsFinite(secondNumber))
            {
                ShowInputError("Please enter a valid, finite number in both boxes.");
                return false;
            }
            return true;
        }

        private double Max(double firstNumber, double secondNumber)
        {
            if (firstNumber > secondNumber)
                return firstNumber;
            return secondNumber;
        }

        private double Power(double firstNumber, double secondNumber)
        {
            return Math.Pow(firstNumber, secondNumber);
        }

        private bool IsPrime(int number)
        {
            if (number < 2)
                return false;

            for (int divisor = 2; divisor <= number / divisor; divisor++)
            {
                if (number % divisor == 0)
                    return false;
            }
            return true;
        }

        private long Factorial(int number)
        {
            long result = 1;
            for (int i = 2; i <= number; i++)
                result *= i;
            return result;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            if (ReadTwoNumbers(out double firstNumber, out double secondNumber))
                lblResult.Text = "Result: " + Max(firstNumber, secondNumber);
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            if (!ReadTwoNumbers(out double firstNumber, out double secondNumber))
                return;

            double result = Power(firstNumber, secondNumber);
            if (!double.IsFinite(result))
            {
                ShowInputError("This power has no finite real result or is too large.");
                return;
            }
            lblResult.Text = "Result: " + result;
        }

        private void btnIsPrime_Click(object sender, EventArgs e)
        {
            // This operation uses only the first input.
            if (!int.TryParse(txtNumber1.Text, out int number))
            {
                ShowInputError("Please enter a whole number between -2147483648 and 2147483647 in the first box.");
                return;
            }
            lblResult.Text = IsPrime(number)
                ? "Result: " + number + " is prime."
                : "Result: " + number + " is not prime.";
        }

        private void btnFactorial_Click(object sender, EventArgs e)
        {
            // 20! is the largest factorial that fits in a long.
            if (!int.TryParse(txtNumber1.Text, out int number) || number < 0 || number > 20)
            {
                ShowInputError("Please enter a whole number from 0 to 20 in the first box.");
                return;
            }
            lblResult.Text = "Result: " + number + "! = " + Factorial(number);
        }
    }
}
