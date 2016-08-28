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
            double value1 = double.Parse(firstTextBox.Text);
            double value2 = double.Parse(secondTextBox.Text);

            resultLabel.Text = (value1 + value2).ToString();

           
        }

        protected void minusButton_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(firstTextBox.Text);
            double value2 = double.Parse(secondTextBox.Text);

            resultLabel.Text = (value1 - value2).ToString();
        }
    
        protected void multButton_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(firstTextBox.Text);
            double value2 = double.Parse(secondTextBox.Text);

            resultLabel.Text = (value1 * value2).ToString();

        }

        protected void divisionButton_Click(object sender, EventArgs e)
        {
            double value1 = double.Parse(firstTextBox.Text);
            double value2 = double.Parse(secondTextBox.Text);

            resultLabel.Text = Math.Round((value1 / value2),3).ToString();
        }
    }
}