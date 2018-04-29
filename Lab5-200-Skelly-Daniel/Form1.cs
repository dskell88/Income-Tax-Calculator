using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5_200_Skelly_Daniel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)       //Calculates Income Tax when user clicks "Calculate"
        {
            decimal income = Convert.ToDecimal(txtTaxIncome.Text);      //converts the tax income textbox from a string to a decimal
            decimal tax = .0m;                                          //initializes the tax variable to 0



            if (income <= 9225)                                         //calculates the tax owned based on the taxable income amount entered                                     
                tax = (int)(income * .10m);
            else if (income > 9225 && income <= 37450)
                tax = 922.50m + (int)((income - 9225) * .15m);
            else if (income > 37450 && income <= 90750)
                tax = 5156.25m + (int)((income - 37450) * .25m);
            else if (income > 90750 && income <= 189300)
                tax = 18481.25m + (int)((income - 90750) * .28m);
            else if (income > 189300 && income <= 411500)
                tax = 46075.25m + (int)((income - 189300) * .33m);
            else if (income > 411500 && income <= 413200)
                tax = 119401.25m + (int)((income - 411500) * .35m);
            else if (income > 413200)
                tax = (int)(income * .396m);

            txtTaxOwned.Text = tax.ToString("c");                     //converts the calculated tax owned to a string and formats it
            txtTaxIncome.Focus();                                     //refers to the tax income object for number input                               


        }

        private void exitButton_Click(object sender, EventArgs e)       //Closes the program when user clicks "Exit"
        {
            this.Close();
        }
    }
}
