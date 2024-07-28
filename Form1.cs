using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // Base prices for coffee types
                decimal totalAmount = 0;
                if (radioButtonCappuccino.Checked) totalAmount += 25;
                if (radioButtonRicofy.Checked) totalAmount += 20;
                if (radioButtonJacobs.Checked) totalAmount += 45;

                // Prices for extras
                if (checkBoxMilk.Checked) totalAmount += 5;
                if (checkBoxHoney.Checked) totalAmount += 7;

                // Display the total amount to spend
                labelTotal.Text = "Total Amount: R" + totalAmount.ToString("0.00");

                // Calculate and display the change
                decimal amountGiven = decimal.Parse(textBoxAmountGiven.Text);
                decimal change = amountGiven - totalAmount;
                labelChange.Text = "Change: R" + change.ToString("0.00");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
    
}
