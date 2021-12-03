using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Collections.Generic;
using Cuestionarios.Controllers;
using System.Linq;
using Npgsql;
using Cuestionarios.Domain;
using Cuestionarios.Sources;

namespace UI
{
    public partial class Game : Form
    {
        private readonly SessionController _sessionController;
        private readonly User _user;
        private int questionNumber;
        private List<Question> _questionsList;
        private readonly string difficulty;
        private Stopwatch stopwatch;
        private int totalQuestions;
        private int correctAnswers;
        private readonly Set selectedSet;
        private readonly static NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public Game(List<Question> questionsList, SessionController sessionController, User user, string pDifficulty, Set pSet)
        {
            _sessionController = sessionController;
            _questionsList = questionsList;
            _user = user;
            selectedSet = pSet;
            difficulty = pDifficulty;

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
                //textQuestion.Text = _questionsList[questionNumber - 1].QuestionSentence;

                btnOption1.Text = _questionsList[questionNumber - 1].Options[0].Answer;
                btnOption2.Text = _questionsList[questionNumber - 1].Options[1].Answer;
                btnOption3.Text = _questionsList[questionNumber - 1].Options[2].Answer;
                btnOption4.Text = _questionsList[questionNumber - 1].Options[3].Answer;

                lblQuestion.Text = "Question " + questionNumber + "/" + totalQuestions + ":";
            }

            else
            {
                timer1.Stop();
                stopwatch.Stop();

                var time = stopwatch.Elapsed;
                double timeNumber = Convert.ToDouble(time.Seconds.ToString());

                try
                {
                    var score = _sessionController.GetScore(selectedSet, correctAnswers, totalQuestions, difficulty, timeNumber);
                    _sessionController.SaveSession(_user, score, time);
                }
                catch (NpgsqlException ex)
                {
                    logger.Debug(ex.ToString());
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    logger.Debug(ex.ToString());
                    MessageBox.Show(ex.Message);
                }

                this.Close();
            }
        }

        private void btnplay_Click(object sender, EventArgs e)
        {
            stopwatch.Start();
            timer1.Enabled = true;
        }

        private void CheckAnswer(int optionSelected)
        {
            if (_questionsList[questionNumber - 1].Options[optionSelected - 1].Correct)
            {
                MessageBox.Show("Correct Answer");
                correctAnswers += 1;
            }
            else
            {
                MessageBox.Show("Incorrect Answer");
            }

            //Show next question
            questionNumber++;
            ShowQuestion();
        }

        private void txtMin_TextChanged(object sender, EventArgs e)
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

        private void btnOption1_Click(object sender, EventArgs e)
        {
            CheckAnswer(1);
        }

        private void btnOption2_Click(object sender, EventArgs e)
        {
            CheckAnswer(2);
        }

        private void btnOption3_Click(object sender, EventArgs e)
        {
            CheckAnswer(3);
        }

        private void btnOption4_Click(object sender, EventArgs e)
        {
            CheckAnswer(4);
        }

        private void textQuestion_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
