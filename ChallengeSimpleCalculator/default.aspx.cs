using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeSimpleCalculator
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void plusButton_Click(object sender, EventArgs e)
        {
            int value1Plus = int.Parse(firstTextBox.Text);
            int value2Plus = int.Parse(secondTextBox.Text);

            int resultPlus = value1Plus + value2Plus;

            resultLabel.Text = resultPlus.ToString();
           
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            int value1Minus = int.Parse(firstTextBox.Text);
            int value2Minus = int.Parse(secondTextBox.Text);

            int resultMinus = value1Minus - value2Minus;

            resultLabel.Text = resultMinus.ToString();
        }

        protected void multButton_Click(object sender, EventArgs e)
        {
            int value1Mult = int.Parse(firstTextBox.Text);
            int value2Mult = int.Parse(secondTextBox.Text);

            int resultMult = value1Mult * value2Mult;

            resultLabel.Text = resultMult.ToString();
        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            double value1Div = int.Parse(firstTextBox.Text);
            double value2Div = int.Parse(secondTextBox.Text);

            double resultDivide = value1Div / value2Div;

            resultLabel.Text = resultDivide.ToString();
        }
    }
}