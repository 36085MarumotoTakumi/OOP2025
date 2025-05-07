using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitConverter
{
    public partial class nud2: Form
    {
        public nud2()
        {
            InitializeComponent();
        }

        private void btChange_Click(object sender, EventArgs e) {
            int num1 = int.Parse(tbNum1.Text);
            double num2 = num1 * 0.3048;

            tbNum2.Text = num2.ToString();
        }

        private void btCalc_Click(object sender, EventArgs e) {
            NudAnswer.Value = NudNum1.Value / NudNum2.Value;
            NudAnswer2.Value = NudNum1.Value % NudNum2.Value;
        }

        private void label6_Click(object sender, EventArgs e) {

        }
    }
}
