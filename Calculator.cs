using AngouriMath;
using AngouriMath.Extensions;

namespace Calculator
{
    public partial class Calculator : Form
    {
        public static double a = 0;
        public static double b = 0;
        public static bool hasDot = false;
        public static short sign = 0;

        public Calculator()
        {
            InitializeComponent();
        }

        public void btnNum_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                if (textBoxShow.Text.Equals("0")) 
                    textBoxShow.Text = "";
                textBoxShow.Text += ((Button)sender).Text;
            }
        }

        public void btnSign_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                textBoxShow.Text += ((Button)sender).Text;
            }
        }

        public void btnDot_Click(object sender, EventArgs e)
        {
            if (textBoxShow.Text.Length == 0 || textBoxShow.Text.Equals("0"))
            {
                textBoxShow.Text = "0.";
            }
            else if (textBoxShow.Text.EndsWith("."))
            {
                textBoxShow.Text = textBoxShow.Text.Remove(textBoxShow.Text.Length - 1);
            }
            else if (Char.IsNumber(textBoxShow.Text.Last()))
            {
                int lastIndex = textBoxShow.Text.LastIndexOf(".");
                if (lastIndex > 0)
                {
                    string checkString = textBoxShow.Text.Substring(lastIndex);
                    if (("+-*/()".Any(checkString.Contains)))
                    {
                        textBoxShow.Text += ".";
                    }
                }
                else textBoxShow.Text += ".";
            }
        }

        public void btnC_Click(object sender, EventArgs e)
        {
            if (textBoxShow.Text.EndsWith("."))
            {
                hasDot = false;
            }
            if (textBoxShow.Text.Length > 0)
                textBoxShow.Text = textBoxShow.Text.Remove(textBoxShow.Text.Length - 1);
        }

        public void btnCL_Click(object sender, EventArgs e)
        {
            textBoxShow.Text = "";
            hasDot = false;
            a = 0;
            b = 0;
            sign = 0;
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (textBoxShow.Text.Length == 0)
            {
                textBoxShow.Text = "0";
                return;
            }

            Entity expr;
            try
            {
                expr = textBoxShow.Text;
                if (expr.EvaluableNumerical)
                {
                    textBoxShow.Text = expr.EvalNumerical().ToString();
                }
                else
                {
                    MessageBox.Show("Math expression isn't right.", "Error");
                }
            } catch (Exception ex)
            {
                MessageBox.Show("Math expression isn't right.", "Error");
            }
        }
    }
}
