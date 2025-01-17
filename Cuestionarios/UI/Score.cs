﻿using Cuestionarios.Controllers;
using System;
using System.Linq;
using System.Windows.Forms;

namespace UI
{
    public partial class Score : Form
    {
        private readonly SessionController _sessionController;
        public Score(SessionController pSessionController)
        {
            _sessionController = pSessionController;

            InitializeComponent();

            try
            {
                scoreGridView.DataSource = _sessionController.GetHighScores().Select(o => new
                { 
                    Username = o.UserName, 
                    Score = o.Score.ToString("N2"), 
                    TimeOnSeconds = o.TotalTimeInSecond.ToString("N2"), 
                    DateOfScore = o.Date 
                }).ToList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Couldn't access highscores: ", exc.Message);
            }
        }

        private void brnAtras_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
