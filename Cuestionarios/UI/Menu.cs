using Cuestionarios.Controllers;
using Cuestionarios.Domain;
using System;
using System.Windows.Forms;

namespace UI
{
    public partial class Menu : Form
    {
        private readonly SetController _setController;
        private readonly QuestionController _questController;
        private readonly SessionController _sessionController;
        private readonly User user;

        public Menu(SetController _setController, QuestionController _questController, SessionController _sessionController, User user)
        {
            this.user = user;
            this._sessionController = _sessionController;
            this._questController = _questController;
            this._setController = _setController;

            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateGame createGame = new CreateGame(_setController, _questController, _sessionController, user)
            {
                Owner = this
            };
            createGame.ShowDialog();
            this.Show();
        }

        private void btnHighScore_Click(object sender, EventArgs e)
        {
            Score score = new Score(_sessionController);
            this.Hide();
            score.ShowDialog();
            this.Show();
        }

        private void exitBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void minimizeBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
