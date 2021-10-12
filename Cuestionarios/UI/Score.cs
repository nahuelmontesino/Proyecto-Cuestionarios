using Cuestionarios.Controllers;
using Microsoft.Build.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class Score : Form
    {
        private readonly SessionController _sessionController;
        public Score(SessionController sessionController)
        {
            _sessionController = sessionController;

            InitializeComponent();

            try
            {
                dataGridView1.DataSource = _sessionController.GetHighScores().Select(o => new
                { Username = o.User, Score = o.ScoreValue, TimeOnSeconds = o.TotalTime, DateOfScore = o.Date }).ToList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Couldn't access highscores: ", exc.Message);
            }
        }
    }
}
