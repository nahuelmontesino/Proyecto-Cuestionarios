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

namespace UI
{
    public partial class Game : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        public Game()
        {
            InitializeComponent();
        }

        private void lblSet_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);

            txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
            txtMil.Text = ts.Milliseconds.ToString();
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer1.Enabled = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            stopwatch.Reset();
            txtMin.Text = "00";
            txtSeg.Text = "00";
            txtMil.Text = "000";
            timer1.Enabled = false;
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void lblQuestion_Click(object sender, EventArgs e)
        {

        }
    }
}
