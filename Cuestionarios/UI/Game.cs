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
        private int questionNumber;
        private List<Question> _questionsList;
        private Stopwatch stopwatch;
        private int totalQuestions;

        public Game(List<Question> questionsList)
        {
            _questionsList = questionsList;
            InitializeComponent();
            questionNumber = 1;
            lblQuestionNumber.Text = questionNumber.ToString();

            stopwatch = new Stopwatch();
            totalQuestions = questionsList.Count;
            timer1.Start();
            stopwatch.Start();

            ShowQuestion();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)stopwatch.ElapsedMilliseconds);

            txtMin.Text = ts.Minutes.ToString().Length < 2 ? "0" + ts.Minutes.ToString() : ts.Minutes.ToString();
            txtSeg.Text = ts.Seconds.ToString().Length < 2 ? "0" + ts.Seconds.ToString() : ts.Seconds.ToString();
        }

        private void ShowQuestion()
        {
            if (questionNumber <= totalQuestions)
            {
                lblQuestionNumber.Text = _questionsList[questionNumber - 1].QuestionSentence;

                btnOption1.Text = _questionsList[questionNumber - 1].Options[0].Answer;
                btnOption2.Text = _questionsList[questionNumber - 1].Options[1].Answer;
                btnOption3.Text = _questionsList[questionNumber - 1].Options[2].Answer;
                btnOption4.Text = _questionsList[questionNumber - 1].Options[3].Answer;

                lblQuestion.Text = "Question " + questionNumber + "/" + totalQuestions + ":";
            }
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

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
