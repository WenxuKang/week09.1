using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace week09._1
{
    public partial class CalculateForm : Form
    {
        public CalculateForm()
        {
            InitializeComponent();
        }

        private void CalculateButtonTableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void CalculateForm1_Click(object sender, EventArgs e)
        {
            var TheButton = sender as Button;

            int buttonValue;
            bool resultCondition = int.TryParse(TheButton.Text, out buttonValue);

            if (resultCondition)
            {
                ResultLabel.Text += TheButton.Text;
            }
            else
            {
                ResultLabel.Text = "Not a number";
            }


            ResultLabel.Text += TheButton.Text;
        }
    }
}
