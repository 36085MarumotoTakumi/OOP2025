using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1: Form {
        Stopwatch sw = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            lbTimeDisp.Text = "00:00:00:00";
            tmDispTimer.Interval = 1;
        }
        private void btStart_Click(object sender, EventArgs e) {
            sw.Start();
            tmDispTimer.Start();
        }

        private void btStop_Click(object sender, EventArgs e) {
            sw.Stop();
            tmDispTimer.Stop();
        }

        private void btReset_Click(object sender, EventArgs e) {
            sw.Reset();
            lbTimeDisp.Text = "00:00:00:00";
        }

        private void btExit_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void tmDispTimer_Tick(object sender, EventArgs e) {
            lbTimeDisp.Text = sw.Elapsed.ToString(@"hh\:mm\:ss\.ff");

        }
    }
}
