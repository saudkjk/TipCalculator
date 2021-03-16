using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TipCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void enterTotalBillTextBox_TextChanged(object sender, EventArgs e)
        {
            computeTip.Enabled = Double.TryParse(enterTotalBillTextBox.Text, out double billDouble) && Double.TryParse(TipPercentageTextBox.Text, out double TipPerDouble);
        }

        private void TipPercentageTextBox_TextChanged(object sender, EventArgs e)
        {
            computeTip.Enabled = Double.TryParse(enterTotalBillTextBox.Text, out double billDouble) && Double.TryParse(TipPercentageTextBox.Text, out double TipPerDouble);
        }

        private void computeTip_Click(object sender, EventArgs e)
        {
            string bill = enterTotalBillTextBox.Text;
            Double.TryParse(bill, out double billDouble);

            string TipPer = TipPercentageTextBox.Text;
            Double.TryParse(TipPer, out double TipPerDouble);

            double tip = billDouble * (TipPerDouble / 100);

            computeTipTextBox.Text = TipPerDouble.ToString() + "%";
            TotalTextBox.Text = (billDouble + tip).ToString();
        }
    }
}
