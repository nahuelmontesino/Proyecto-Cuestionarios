using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using Cuestionarios.Controllers;
using Cuestionarios.Models.Domain;
using System.Linq;

namespace UI
{
    public partial class Game : Form
    {
        Stopwatch stopwatch = new Stopwatch();
        private readonly QuestionController _questController;
        private int questionNumber;
        private List<Question> questionsList;

        public Game(Set pset, string pDifficulty, string pCategory, int pAmount)
        {
            InitializeComponent();
            questionNumber = 1;
            lblQustionNumber.Text = questionNumber.ToString();

            questionsList = _questController.GetQuestions(pset, pDifficulty, pCategory, pAmount).ToList();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);

            txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();

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
