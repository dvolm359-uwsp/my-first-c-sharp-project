/* ================================================
 * @author     David Volm aka VOLMINATOR aka daXXog
 * @date       Sun Mar  6 13:09:22 CST 2022
 * @school     UWSP
 * @class      CIS 340
 * @section    01
 * @assignment 04
 * @professor  Hardeep Kaur Dhalla
 * @licence    MIT
 * ===============================================*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvoiceCalculator
{
    public partial class Form1 : Form
    {
        private readonly InvoiceCalculator invoiceCalculator = new InvoiceCalculator();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void subtotalLabel_Click(object sender, EventArgs e)
        {

        }

        private void discountPercentLabel_Click(object sender, EventArgs e)
        {

        }

        private void subtotalText_TextChanged(object sender, EventArgs e)
        {
            subtotalErrorProvider.SetError(subtotalText, "");
        }

        private void discountAmountLabel_Click(object sender, EventArgs e)
        {

        }

        private void discountAmountText_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalLabel_Click(object sender, EventArgs e)
        {

        }

        private void totalText_TextChanged(object sender, EventArgs e)
        {

        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void discountPercentText_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            invoiceCalculator.parseAndSetSubtotal(subtotalText.Text, () => {
                discountPercentText.Text = invoiceCalculator.DiscountPercent;
                discountAmountText.Text = invoiceCalculator.DiscountAmount;
                totalText.Text = invoiceCalculator.Total;
            }, () => {
                subtotalErrorProvider.SetError(subtotalText, "Please enter a valid number in the text box!");
                discountPercentText.Text = "";
                discountAmountText.Text = "";
                totalText.Text = "";
            });
        }
    }
}
