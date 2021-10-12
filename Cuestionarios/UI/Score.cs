using Cuestionarios.Controllers;
using System;
using System.Linq;
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
                dataGridView1.DataSource = _sessionController.GetHighScores().ToList();
            }
            catch (Exception exc)
            {
                MessageBox.Show("Couldn't access highscores: ", exc.Message);
            }
        }
    }
}
