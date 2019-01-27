using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Calculator
{
    public partial class simpleCalculator : Form
    {
        const string noValue = "0";

        public simpleCalculator()
        {
            InitializeComponent();
        }

        private void simpleCalculator_Load(object sender, EventArgs e)
        {

        }

        private void btnNumber_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (lblValue.Text == noValue)
            {
                lblValue.Text = String.Empty;
            }
            lblValue.Text += btn.Text;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string newValue = noValue;

        }
    }
}
